namespace SlaeSolver
{
    partial class FormInput
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInputType = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numudRandomN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomInput = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFileInput = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnManualInput = new System.Windows.Forms.Button();
            this.cbStateOk = new System.Windows.Forms.CheckBox();
            this.btnShowMatrix = new System.Windows.Forms.Button();
            this.cbLuDecompositionMulti = new System.Windows.Forms.CheckBox();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.cbLight = new System.Windows.Forms.CheckBox();
            this.cbGaussian = new System.Windows.Forms.CheckBox();
            this.cbLuDecomposition = new System.Windows.Forms.CheckBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.gbInputType.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudRandomN)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInputType
            // 
            this.gbInputType.Controls.Add(this.btnClear);
            this.gbInputType.Controls.Add(this.tabControl1);
            this.gbInputType.Controls.Add(this.cbStateOk);
            this.gbInputType.Controls.Add(this.btnShowMatrix);
            this.gbInputType.Location = new System.Drawing.Point(12, 12);
            this.gbInputType.Name = "gbInputType";
            this.gbInputType.Size = new System.Drawing.Size(192, 124);
            this.gbInputType.TabIndex = 1;
            this.gbInputType.TabStop = false;
            this.gbInputType.Text = "Input type";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(138, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(44, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(180, 64);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numudRandomN);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnRandomInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(172, 38);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Random";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numudRandomN
            // 
            this.numudRandomN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numudRandomN.Location = new System.Drawing.Point(31, 9);
            this.numudRandomN.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numudRandomN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numudRandomN.Name = "numudRandomN";
            this.numudRandomN.Size = new System.Drawing.Size(63, 21);
            this.numudRandomN.TabIndex = 5;
            this.numudRandomN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "N:";
            // 
            // btnRandomInput
            // 
            this.btnRandomInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRandomInput.Location = new System.Drawing.Point(100, 3);
            this.btnRandomInput.Name = "btnRandomInput";
            this.btnRandomInput.Size = new System.Drawing.Size(69, 32);
            this.btnRandomInput.TabIndex = 5;
            this.btnRandomInput.Text = "Generate";
            this.btnRandomInput.UseVisualStyleBackColor = true;
            this.btnRandomInput.Click += new System.EventHandler(this.BtnRandomInput_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFileInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(172, 38);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFileInput
            // 
            this.btnFileInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFileInput.Location = new System.Drawing.Point(3, 3);
            this.btnFileInput.Name = "btnFileInput";
            this.btnFileInput.Size = new System.Drawing.Size(166, 32);
            this.btnFileInput.TabIndex = 4;
            this.btnFileInput.Text = "Read from directory";
            this.btnFileInput.UseVisualStyleBackColor = true;
            this.btnFileInput.Click += new System.EventHandler(this.BtnFileInput_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnManualInput);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(172, 38);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manual";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnManualInput
            // 
            this.btnManualInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManualInput.Location = new System.Drawing.Point(3, 3);
            this.btnManualInput.Name = "btnManualInput";
            this.btnManualInput.Size = new System.Drawing.Size(166, 32);
            this.btnManualInput.TabIndex = 5;
            this.btnManualInput.Text = "Open editor";
            this.btnManualInput.UseVisualStyleBackColor = true;
            this.btnManualInput.Click += new System.EventHandler(this.BtnManualInput_Click);
            // 
            // cbStateOk
            // 
            this.cbStateOk.AutoSize = true;
            this.cbStateOk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbStateOk.Enabled = false;
            this.cbStateOk.Location = new System.Drawing.Point(6, 93);
            this.cbStateOk.Name = "cbStateOk";
            this.cbStateOk.Size = new System.Drawing.Size(47, 17);
            this.cbStateOk.TabIndex = 2;
            this.cbStateOk.Text = "OK?";
            this.cbStateOk.UseVisualStyleBackColor = true;
            // 
            // btnShowMatrix
            // 
            this.btnShowMatrix.Enabled = false;
            this.btnShowMatrix.Location = new System.Drawing.Point(59, 89);
            this.btnShowMatrix.Name = "btnShowMatrix";
            this.btnShowMatrix.Size = new System.Drawing.Size(73, 23);
            this.btnShowMatrix.TabIndex = 3;
            this.btnShowMatrix.Text = "Show matrix";
            this.btnShowMatrix.UseVisualStyleBackColor = true;
            this.btnShowMatrix.Click += new System.EventHandler(this.BtnShowMatrix_Click);
            // 
            // cbLuDecompositionMulti
            // 
            this.cbLuDecompositionMulti.AutoSize = true;
            this.cbLuDecompositionMulti.Location = new System.Drawing.Point(6, 42);
            this.cbLuDecompositionMulti.Name = "cbLuDecompositionMulti";
            this.cbLuDecompositionMulti.Size = new System.Drawing.Size(173, 17);
            this.cbLuDecompositionMulti.TabIndex = 3;
            this.cbLuDecompositionMulti.Text = "LU Decomposition (multithread)";
            this.cbLuDecompositionMulti.UseVisualStyleBackColor = true;
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.cbLight);
            this.gbConfig.Controls.Add(this.cbGaussian);
            this.gbConfig.Controls.Add(this.cbLuDecomposition);
            this.gbConfig.Controls.Add(this.btnExecute);
            this.gbConfig.Controls.Add(this.cbLuDecompositionMulti);
            this.gbConfig.Location = new System.Drawing.Point(12, 142);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(192, 144);
            this.gbConfig.TabIndex = 4;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Configuration";
            // 
            // cbLight
            // 
            this.cbLight.AutoSize = true;
            this.cbLight.Location = new System.Drawing.Point(6, 92);
            this.cbLight.Name = "cbLight";
            this.cbLight.Size = new System.Drawing.Size(78, 17);
            this.cbLight.TabIndex = 6;
            this.cbLight.Text = "Light mode";
            this.cbLight.UseVisualStyleBackColor = true;
            // 
            // cbGaussian
            // 
            this.cbGaussian.AutoSize = true;
            this.cbGaussian.Location = new System.Drawing.Point(6, 65);
            this.cbGaussian.Name = "cbGaussian";
            this.cbGaussian.Size = new System.Drawing.Size(108, 17);
            this.cbGaussian.TabIndex = 5;
            this.cbGaussian.Text = "Gaussian method";
            this.cbGaussian.UseVisualStyleBackColor = true;
            // 
            // cbLuDecomposition
            // 
            this.cbLuDecomposition.AutoSize = true;
            this.cbLuDecomposition.Location = new System.Drawing.Point(6, 19);
            this.cbLuDecomposition.Name = "cbLuDecomposition";
            this.cbLuDecomposition.Size = new System.Drawing.Size(161, 17);
            this.cbLuDecomposition.TabIndex = 4;
            this.cbLuDecomposition.Text = "LU Decomposition (1 thread)";
            this.cbLuDecomposition.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(6, 115);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(176, 23);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 298);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.gbInputType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInput";
            this.Text = "SLAE SOLVER : Input";
            this.gbInputType.ResumeLayout(false);
            this.gbInputType.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudRandomN)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInputType;
        private System.Windows.Forms.CheckBox cbStateOk;
        private System.Windows.Forms.Button btnShowMatrix;
        private System.Windows.Forms.CheckBox cbLuDecompositionMulti;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.CheckBox cbGaussian;
        private System.Windows.Forms.CheckBox cbLuDecomposition;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numudRandomN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomInput;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnFileInput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnManualInput;
        private System.Windows.Forms.CheckBox cbLight;
    }
}

