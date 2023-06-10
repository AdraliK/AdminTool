using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdminTool2.Windows
{
    public partial class GraphControl : UserControl
    {
        private Panel panel;
        private SummaryUserControl.STATS_TYPE type;

        public GraphControl(ref Panel panel, SummaryUserControl.STATS_TYPE type)
        {
            InitializeComponent();
            this.panel = panel;
            this.type = type;

            DrawGraph();
        }

        private void DrawGraph()
        {
            string filePath = "..\\..\\Resourses\\data.txt";

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.Legends[0].Enabled = false;

            int i0, i1, j = 0;

            int breakEvenValue = (int)(MainWindow.breakEven_MicroMarket * SummaryUserControl.outlet.outlet.Count);
            int targetValue = (int)(MainWindow.target_MicroMarket * SummaryUserControl.outlet.outlet.Count);

            i0 = File.ReadLines(filePath).Count() - DateTime.Now.Subtract(SummaryUserControl.firstDate).Days - 1;
            i1 = File.ReadLines(filePath).Count() - DateTime.Now.Subtract(SummaryUserControl.secondDate).Days;

            if (type == SummaryUserControl.STATS_TYPE.Proceeds)
            {
                chart1.Series.Add(new Series());
                chart1.Series[1].ChartType = SeriesChartType.Line;
                chart1.Series[1].Color = Color.Red;

                chart1.Series.Add(new Series());
                chart1.Series[2].ChartType = SeriesChartType.Line;
                chart1.Series[2].Color = Color.Green;
            }

            if (checkBox1.Checked == true)
            {
                for (int i = i0; i < i1; i++)
                {
                    string[] parts = File.ReadLines(filePath).ElementAt(i).Split('|');
                    if (type == SummaryUserControl.STATS_TYPE.Proceeds)
                    {
                        chart1.Series[0].Points.Add(int.Parse(parts[1]));
                        chart1.Series[1].Points.Add(breakEvenValue);
                        chart1.Series[2].Points.Add(targetValue);
                    }
                    else if (type == SummaryUserControl.STATS_TYPE.AvgCheck) chart1.Series[0].Points.Add(int.Parse(parts[1]) / int.Parse(parts[2]));

                    chart1.ChartAreas[0].AxisX.CustomLabels.Add(j + 0.5, j + 1.5, DateTime.ParseExact(parts[0], "dd.MM.yyyy", null).ToString("ddd dd.MM", new System.Globalization.CultureInfo("ru-RU")));

                    j++;
                }
            }
            else
            {
                for (int i = i0; i < i1; i++)
                {
                    string[] parts = File.ReadLines(filePath).ElementAt(i).Split('|');

                    if (!(DateTime.ParseExact(parts[0], "dd.MM.yyyy", null).DayOfWeek == DayOfWeek.Sunday || DateTime.ParseExact(parts[0], "dd.MM.yyyy", null).DayOfWeek == DayOfWeek.Saturday))
                    {
                        if (type == SummaryUserControl.STATS_TYPE.Proceeds)
                        {
                            chart1.Series[0].Points.Add(int.Parse(parts[1]));
                            chart1.Series[1].Points.Add(breakEvenValue);
                            chart1.Series[2].Points.Add(targetValue);
                        }
                        else if (type == SummaryUserControl.STATS_TYPE.AvgCheck) chart1.Series[0].Points.Add(int.Parse(parts[1]) / int.Parse(parts[2]));

                        chart1.ChartAreas[0].AxisX.CustomLabels.Add(j + 0.5, j + 1.5, DateTime.ParseExact(parts[0], "dd.MM.yyyy", null).ToString("ddd dd.MM", new System.Globalization.CultureInfo("ru-RU")));

                        j++;
                    }
                }
            }

            if (type == SummaryUserControl.STATS_TYPE.AvgCheck)
            {
                chart1.Series.Add("TrendLine");

                chart1.Series["TrendLine"].ChartType = SeriesChartType.Line;
                chart1.Series["TrendLine"].BorderDashStyle = ChartDashStyle.Dash;
                //chart1.Series["TrendLine"].BorderWidth = 1;
                chart1.Series["TrendLine"].Color = Color.Gray;

                chart1.Series[0].Sort(PointSortOrder.Ascending, "X");
                chart1.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, "Linear,1,false,false", chart1.Series[0], chart1.Series["TrendLine"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.Controls.Remove(this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = SeriesChartType.Line;

            DrawGraph();
        }
    }
}
