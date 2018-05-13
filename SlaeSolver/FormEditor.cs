using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SlaeSolver
{
    public delegate void SlaeSetter(Slae values);

    public partial class FormEditor : Form
    {
        public int N { get; private set; }
        public double[][] Matrix { get; private set; }
        public double[] B { get; private set; }

        SlaeSetter ss;

        public FormEditor(SlaeSetter ss)
        {
            InitializeComponent();
            sfdSave.InitialDirectory = Directory.GetCurrentDirectory();

            NumudN_ValueChanged(this, EventArgs.Empty);
            this.ss = ss;
        }

        private void CreateDgvTable()
        {
            Matrix = new double[N][];
            B = new double[N];

            for (int i = 0; i < N; i++)            
                Matrix[i] = new double[N];
            
            CreateDgvTable(dgvData, N);
        }

        public static void CreateDgvTable(DataGridView dgvData, int N)
        {
            dgvData.Rows.Clear();
            dgvData.Columns.Clear();

            for(int i = 0; i < N; i++)
            {
                string col = $"X {i+1}";
                dgvData.Columns.Add(col, col);
                dgvData.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).Width = 60;
            }
            dgvData.Columns.Add("equal", "=");
            dgvData.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).Width = 60;

            dgvData.Rows.Add(N);
        }

        private void NumudN_ValueChanged(object sender, EventArgs e)
        {
            N = (int)numudN.Value;
            CreateDgvTable();
        }

        private void DgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != N) // if not at equal place
            {
                if (!Double.TryParse(dgvData[e.ColumnIndex, e.RowIndex].Value.ToString(), out Matrix[e.RowIndex][e.ColumnIndex]))
                    dgvData[e.ColumnIndex, e.RowIndex].Value = Matrix[e.RowIndex][e.ColumnIndex] = 0;
            }
            else
                if (!Double.TryParse(dgvData[e.ColumnIndex, e.RowIndex].Value.ToString(), out B[e.RowIndex]))
                    dgvData[e.ColumnIndex, e.RowIndex].Value = B[e.RowIndex] = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                using (var stream = sfdSave.OpenFile())
                {
                    SlaeIO.Write(Matrix, B, stream);
                }
                NotificationManager.ShowInfo($"File has been saved to directory:{Environment.NewLine}{sfdSave.FileName}");
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                DataGridViewRow row = dgvData.Rows[i];
                for (int j = 0; j < row.Cells.Count - 1; j++) // contains equal row, so use without last
                {
                    Matrix[i][j] = Convert.ToDouble(dgvData[j, i].Value);
                }
            }

            ss(new Slae(Matrix, B));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
