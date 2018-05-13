using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlaeSolver
{
    public enum RunningStates { IDLE, RUNNING, COMPLETE, FAILURE}

    public partial class FormExecute : Form
    {
        Slae slae;
        double[][] results;

        List<ISlaeSolvingMethod> solvingMethods;
        int activeMethod;

        bool lightMode;
        PerformanceCounter cpuCounter, memCounter;
        TimeSpan totalT;
        static int perfomanceCounterSeconds = 60;
        Queue<double> cpuQueue, memQueue;


        public FormExecute(Slae slae, List<ISlaeSolvingMethod> solvingMethods, bool lightMode = false)
        {
            if (solvingMethods.Count == 0)
                throw new ArgumentException("Solving Methods count = 0");
            else
            {
                InitializeComponent();
                this.slae = slae;
                this.solvingMethods = solvingMethods;
                results = new double[solvingMethods.Count][];

                this.lightMode = lightMode;
                if(!lightMode)
                {
                    totalT = new TimeSpan();
                    ConfigurePerfomanceCounters();
                }
                else
                {
                    CleanupWnd();
                }
            }
        }

        private void ConfigurePerfomanceCounters()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            memCounter = new PerformanceCounter("Memory", "Available MBytes");// "% Committed Bytes In Use");//
            cpuQueue = new Queue<double>(new double[perfomanceCounterSeconds]);
            memQueue = new Queue<double>(new double[perfomanceCounterSeconds]);
            chartCpu.ChartAreas[0].AxisY.Minimum = chartMem.ChartAreas[0].AxisY.Minimum = 0;
            chartCpu.ChartAreas[0].AxisY.Maximum = 100;
            chartMem.ChartAreas[0].AxisY.Maximum =
                new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024;
        }

        private void DeactivatePerfomanceCounter()
        {
            timerPerfomance.Stop();
            lbCpuLoad.Text = "CPU: ---- %";
            lbMemoryLoad.Text = "Memory: ---- MB";
        }

        private void CleanupWnd()
        {
            chartCpu = null;
            chartMem = null;
            cpuQueue = null;
            memQueue = null;
            lbCpuLoad = null;
            lbFullT = null;
            lbMemoryLoad = null;
            timerPerfomance = null;
            tableLayoutPanel3 = null;
            Size = MinimumSize = new Size(400, 275);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            GC.Collect();
        }
        
        private void TimerPerfomance_Tick(object sender, EventArgs e)
        {
            float cpuValue = cpuCounter.NextValue(), memValue = memCounter.NextValue();
            lbCpuLoad.Text = $"CPU: {cpuValue:f2} %";
            lbMemoryLoad.Text = $"Memory free: {memValue} MB";

            totalT = totalT.Add(TimeSpan.FromSeconds(1));
            lbFullT.Text = $"Total: {totalT}";

            UpdatePerfomanceCharts(cpuValue, memValue);
        }

        private void UpdatePerfomanceCharts(float cpuValue, float memValue)
        {
            cpuQueue.Dequeue();
            cpuQueue.Enqueue(cpuValue);
            memQueue.Dequeue();
            memQueue.Enqueue(memValue);
            chartCpu.Series[0].Points.Clear();
            chartMem.Series[0].Points.Clear();
            for (int i = 0; i < perfomanceCounterSeconds; i++)
            {
                chartCpu.Series[0].Points.AddXY(i + 1, cpuQueue.ElementAt(i));
                chartMem.Series[0].Points.AddXY(i + 1, memQueue.ElementAt(i));
            }
        }

        private void AddLog(RunningStates state)
        {
            lbLog.Items.Add($"[{DateTime.Now.ToLongTimeString()}{(lightMode ? "" : $" | {totalT}")}]" +
                $" {solvingMethods[activeMethod].ToString()} {state}");
        }

        private void AddLog(string value)
        {
            lbLog.Items.Add($"[{DateTime.Now.ToLongTimeString()}{(lightMode ? "" : $" | {totalT}")}]" +
                $" {solvingMethods[activeMethod].ToString()} {value}");
        }

        private void BtnShowMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                new FormShowMatrix(slae).ShowDialog();
            }
            catch (Exception exc)
            {
                NotificationManager.ShowError(exc);
            }
        }

        private void DgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (results[e.RowIndex] != null)
                {
                    try
                    {
                        switch (e.ColumnIndex)
                        {
                            case 3:
                                // roots
                                new FormShowMatrix(new double[1][] { results[e.RowIndex] }).ShowDialog();
                                break;
                            case 4:
                                // save  
                                if (sfdSave.ShowDialog() == DialogResult.OK)
                                {
                                    using (var stream = sfdSave.OpenFile())
                                    {
                                        SlaeIO.Write(results[e.RowIndex], stream);
                                    }
                                    NotificationManager.ShowInfo($"File has been saved to directory:{Environment.NewLine}{sfdSave.FileName}");
                                }
                                break;
                        }
                    }
                    catch (Exception exc)
                    {
                        NotificationManager.ShowError(exc);
                    }
                }
            }
        }

        private void BtnShowAllResults_Click(object sender, EventArgs e)
        {
            try
            {
                new FormShowMatrix(results).ShowDialog();
            }
            catch (Exception exc)
            {
                NotificationManager.ShowError(exc);
            }
        }

        private async void FormExecute_Load(object sender, EventArgs e)
        {
            for (activeMethod = 0; activeMethod < solvingMethods.Count; activeMethod++)
            {
                dgvResults.Rows.Add(solvingMethods[activeMethod].ToString(), RunningStates.IDLE.ToString(), "N/A");
            }

            if (!lightMode)
                timerPerfomance.Start();

            for (activeMethod = 0; activeMethod < solvingMethods.Count; activeMethod++)
            {
                try
                {
                    dgvResults[1, activeMethod].Value = RunningStates.RUNNING;
                    AddLog(RunningStates.RUNNING);
                    DateTime prevT = DateTime.Now;

                    results[activeMethod] = await ExecMethodAsync(solvingMethods[activeMethod], slae);

                    dgvResults[1, activeMethod].Value = RunningStates.COMPLETE;
                    AddLog(RunningStates.COMPLETE);
                    dgvResults[2, activeMethod].Value = (DateTime.Now - prevT).ToString();
                    dgvResults[3, activeMethod].Value = "Roots";
                    dgvResults[4, activeMethod].Value = "Save";

                    AddLog(slae.IsCorrect(results[activeMethod]) ? "YES" : "NO");
                }
                catch (Exception exc)
                {
                    NotificationManager.ShowError(exc);
                    AddLog(RunningStates.FAILURE);
                    dgvResults[1, activeMethod].Value = RunningStates.FAILURE;
                }
            }
            DeactivatePerfomanceCounter();
        }

        private static async Task<double[]> ExecMethodAsync(ISlaeSolvingMethod method, Slae slae)
        {
            return await Task<double[]>.Factory.StartNew(() =>
            {
                return method.Solve(slae);
            });
        }
    }
}
