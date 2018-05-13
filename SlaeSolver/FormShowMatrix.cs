using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlaeSolver
{
    public partial class FormShowMatrix : Form
    {
        public FormShowMatrix(Slae slae)
        {
            InitializeComponent();
            FillDgv(dgvData, slae);
        }

        public FormShowMatrix(double[][] data)
        {
            InitializeComponent();
            FillDgv(dgvData, data);
        }

        public static void FillDgv(DataGridView dgvData, Slae slae)
        {
            if (slae.N <= 650)
            {
                FormEditor.CreateDgvTable(dgvData, slae.N);
                for (int i = 0; i < slae.N; i++)
                {
                    for (int j = 0; j < slae.N + 1; j++)
                    {
                        dgvData[j, i].Value = slae[i, j];
                    }
                }
            }
            else
                throw new ArgumentException("N > 650, unable to show this slae in the form");
        }

        public static void FillDgv(DataGridView dgvData, double[][] data)
        {
            if (data.Length != 0)
            {
                if (data[0].Length > 650)
                    if(data.Length == 1)
                        data = ModifyArray(data[0], 100);
                    else
                        throw new ArgumentException("Unable to show data in the form. " +
                            "Try to watch it with buttons \'Roots\' or by saving it to file");

                CreateDgvTable(dgvData, data.Length, data[0].Length);
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 0; j < data[i].Length; j++)
                    {
                        dgvData[j, i].Value = data[i][j];
                    }
                }

            }
            else
                throw new ArgumentException("Unable to show data in the form");
        }

        public static double[][] ModifyArray(double[] data, int xCount)
        {
            int elementsLeft = data.Length;
            int iterations = (int)Math.Ceiling((elementsLeft / (double)xCount));
            //double[] tmp = new double[xCount];
            double[][] newData = new double[iterations][];

            for (int k = 0; k < iterations - 1; k++, elementsLeft -= xCount)
            {
                newData[k] = new double[xCount];
                Array.Copy(data, xCount * k, newData[k], 0, xCount);
            }
            newData[iterations - 1] = new double[xCount];
            Array.Copy(data, xCount * (iterations - 1), newData[iterations - 1], 0, elementsLeft);
            for (int i = elementsLeft; i < xCount; i++)
                newData[iterations - 1][i] = double.NaN;

            return newData;
        }

        // NxM
        public static void CreateDgvTable(DataGridView dgvData, int N, int M)
        {
            dgvData.Rows.Clear();
            dgvData.Columns.Clear();

            for (int i = 0; i < M; i++)
            {
                string col = $"X {i + 1}";
                dgvData.Columns.Add(col, col);
                dgvData.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).Width = 60;
            }

            dgvData.Rows.Add(N);
        }
    }
}
