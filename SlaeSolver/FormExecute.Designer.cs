using System.Windows.Forms.DataVisualization.Charting;

namespace SlaeSolver
{
    partial class FormExecute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShowMatrix = new System.Windows.Forms.ToolStripButton();
            this.btnShowAllResults = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chartMem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFullT = new System.Windows.Forms.Label();
            this.lbMemoryLoad = new System.Windows.Forms.Label();
            this.lbCpuLoad = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeEstimated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoots = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColSave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.timerPerfomance = new System.Windows.Forms.Timer(this.components);
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowMatrix,
            this.btnShowAllResults});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(811, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShowMatrix
            // 
            this.btnShowMatrix.Image = global::SlaeSolver.Properties.Resources.imgMatrix;
            this.btnShowMatrix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowMatrix.Name = "btnShowMatrix";
            this.btnShowMatrix.Size = new System.Drawing.Size(92, 22);
            this.btnShowMatrix.Text = "Show matrix";
            this.btnShowMatrix.Click += new System.EventHandler(this.BtnShowMatrix_Click);
            // 
            // btnShowAllResults
            // 
            this.btnShowAllResults.Image = global::SlaeSolver.Properties.Resources.imgMatrix;
            this.btnShowAllResults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAllResults.Name = "btnShowAllResults";
            this.btnShowAllResults.Size = new System.Drawing.Size(108, 22);
            this.btnShowAllResults.Text = "Show all results";
            this.btnShowAllResults.Click += new System.EventHandler(this.BtnShowAllResults_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 271);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.chartMem, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.chartCpu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(383, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(425, 265);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // chartMem
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMem.ChartAreas.Add(chartArea1);
            this.chartMem.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartMem.Legends.Add(legend1);
            this.chartMem.Location = new System.Drawing.Point(3, 145);
            this.chartMem.Name = "chartMem";
            this.chartMem.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Memory free";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartMem.Series.Add(series1);
            this.chartMem.Size = new System.Drawing.Size(419, 117);
            this.chartMem.TabIndex = 2;
            this.chartMem.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Memory free";
            this.chartMem.Titles.Add(title1);
            // 
            // chartCpu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCpu.ChartAreas.Add(chartArea2);
            this.chartCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "CPU load";
            this.chartCpu.Legends.Add(legend2);
            this.chartCpu.Location = new System.Drawing.Point(3, 23);
            this.chartCpu.Name = "chartCpu";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.IsXValueIndexed = true;
            series2.Legend = "CPU load";
            series2.Name = "CPU load";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartCpu.Series.Add(series2);
            this.chartCpu.Size = new System.Drawing.Size(419, 116);
            this.chartCpu.TabIndex = 0;
            this.chartCpu.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "CPU load";
            this.chartCpu.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFullT);
            this.panel1.Controls.Add(this.lbMemoryLoad);
            this.panel1.Controls.Add(this.lbCpuLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 14);
            this.panel1.TabIndex = 1;
            // 
            // lbFullT
            // 
            this.lbFullT.AutoSize = true;
            this.lbFullT.Location = new System.Drawing.Point(246, 0);
            this.lbFullT.Name = "lbFullT";
            this.lbFullT.Size = new System.Drawing.Size(79, 13);
            this.lbFullT.TabIndex = 3;
            this.lbFullT.Text = "Total: 00:00:00";
            // 
            // lbMemoryLoad
            // 
            this.lbMemoryLoad.AutoSize = true;
            this.lbMemoryLoad.Location = new System.Drawing.Point(88, 0);
            this.lbMemoryLoad.Name = "lbMemoryLoad";
            this.lbMemoryLoad.Size = new System.Drawing.Size(114, 13);
            this.lbMemoryLoad.TabIndex = 1;
            this.lbMemoryLoad.Text = "Memory free: 0000 MB";
            // 
            // lbCpuLoad
            // 
            this.lbCpuLoad.AutoSize = true;
            this.lbCpuLoad.Location = new System.Drawing.Point(3, 0);
            this.lbCpuLoad.Name = "lbCpuLoad";
            this.lbCpuLoad.Size = new System.Drawing.Size(79, 13);
            this.lbCpuLoad.TabIndex = 0;
            this.lbCpuLoad.Text = "CPU: 000.00 %";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvResults, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbLog, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 265);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColState,
            this.ColTimeEstimated,
            this.ColRoots,
            this.ColSave});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(3, 3);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(368, 94);
            this.dgvResults.TabIndex = 2;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResults_CellContentClick);
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Method";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 135;
            // 
            // ColState
            // 
            this.ColState.HeaderText = "State";
            this.ColState.Name = "ColState";
            this.ColState.ReadOnly = true;
            this.ColState.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColState.Width = 70;
            // 
            // ColTimeEstimated
            // 
            dataGridViewCellStyle1.Format = "c";
            this.ColTimeEstimated.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColTimeEstimated.HeaderText = "T est.";
            this.ColTimeEstimated.Name = "ColTimeEstimated";
            this.ColTimeEstimated.ReadOnly = true;
            this.ColTimeEstimated.Width = 65;
            // 
            // ColRoots
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "N/A";
            this.ColRoots.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColRoots.HeaderText = "Roots";
            this.ColRoots.Name = "ColRoots";
            this.ColRoots.ReadOnly = true;
            this.ColRoots.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColRoots.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColRoots.Text = "";
            this.ColRoots.Width = 40;
            // 
            // ColSave
            // 
            this.ColSave.HeaderText = "Save";
            this.ColSave.Name = "ColSave";
            this.ColSave.ReadOnly = true;
            this.ColSave.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColSave.Width = 35;
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(3, 103);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(368, 159);
            this.lbLog.TabIndex = 3;
            // 
            // timerPerfomance
            // 
            this.timerPerfomance.Interval = 1000;
            this.timerPerfomance.Tick += new System.EventHandler(this.TimerPerfomance_Tick);
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "txt";
            this.sfdSave.Filter = ".txt files|*.txt|All files|*.*";
            // 
            // FormExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 296);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(750, 275);
            this.Name = "FormExecute";
            this.Text = "SLAE SOLVER : Execute";
            this.Load += new System.EventHandler(this.FormExecute_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnShowMatrix;
        private System.Windows.Forms.ToolStripButton btnShowAllResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Timer timerPerfomance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Chart chartCpu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFullT;
        private System.Windows.Forms.Label lbMemoryLoad;
        private System.Windows.Forms.Label lbCpuLoad;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeEstimated;
        private System.Windows.Forms.DataGridViewButtonColumn ColRoots;
        private System.Windows.Forms.DataGridViewButtonColumn ColSave;
    }
}