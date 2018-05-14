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
    public partial class FormInput : Form
    {
        Slae slae;
        public Slae Slae
        {
            get { return slae; }
            private set { slae = value; SlaeChangingListener(); }
        }

        private void SlaeChangingListener()
        {
            cbStateOk.Checked = (slae == null) ? false : true;
            btnShowMatrix.Enabled = btnClear.Enabled = btnExecute.Enabled = cbStateOk.Checked;
            GC.Collect();
        }

        public FormInput()
        {
            InitializeComponent();
        }

        private void BtnRandomInput_Click(object sender, EventArgs e)
        {
            btnRandomInput.Text = "Generating";
            btnRandomInput.Enabled = false;
            try
            {
                Slae = new Slae((int)numudRandomN.Value);
            }
            catch (Exception exc)
            {
                NotificationManager.ShowError(exc);
            }
            finally
            {
                GC.Collect();
                btnRandomInput.Text = "Generate";
                btnRandomInput.Enabled = true;
            }
        }

        private void BtnFileInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd;
            if ((ofd = new OpenFileDialog()).ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = ofd.OpenFile())
                    {
                        Slae = SlaeIO.Read(stream);
                    }
                    NotificationManager.ShowInfo("Reading completed successfully");
                }
                catch(Exception exc)
                {
                    NotificationManager.ShowError(exc);
                }
            }
        }

        private void BtnManualInput_Click(object sender, EventArgs e)
        {
            new FormEditor((val) => Slae = val).ShowDialog();
        }

        private void BtnShowMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                new FormShowMatrix(slae).ShowDialog();
            }
            catch(Exception exc)
            {
                NotificationManager.ShowError(exc);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Slae = null;
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            List<ISlaeSolvingMethod> slaeSolvingMethods = new List<ISlaeSolvingMethod>();

            if (cbLuDecomposition.Checked)
                slaeSolvingMethods.Add(new LuDecomposition());
            if (cbLuDecompositionMulti.Checked)
                slaeSolvingMethods.Add(new LuDecompositionAsync());
            if (cbGaussian.Checked)
                slaeSolvingMethods.Add(new GaussianMethod());
            
            if (slaeSolvingMethods.Count == 0)
                NotificationManager.ShowExclamation("Choose solving methods before executing");
            else
            {
                new FormExecute(slae, slaeSolvingMethods, cbLight.Checked).ShowDialog();
                GC.Collect();
            }
        }
    }
}
