using AdminTool2.MyControls;
using AdminTool2.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdminTool2
{
    public partial class SummaryUserControl : UserControl
    {
        public static OutletStats productSats, outlet;       
        private Panel panel;
        public static int days;

        public static DateTime firstDate, secondDate;
        private bool isSelectingRange;

        public enum STATS_TYPE { Outlets, Positions, Proceeds, AvgCheck};

        public SummaryUserControl(ref Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            buttonNowDay.PerformClick();
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].BorderColor = Color.White;
        }

        private Button btn;
        private void button_Click(object sender, EventArgs e)
        {

            (sender as Button).BackColor = Color.FromArgb(22, 173, 96);
            (sender as Button).ForeColor = Color.White;

            if (btn != null)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(35, 39, 53);
            }
            btn = (sender as Button);

            switch ((sender as Button).Name)
            {
                case "buttonLastDay": foo(0); break;
                case "buttonNowDay": foo(1); break;
                case "buttonWeek": foo(7); break;
                case "buttonMonth": foo(31); break;
                case "buttonAccept": 
                    foo(-1);
                    monthCalendar1.Location = new Point(monthCalendar1.Location.X, -300);
                    break;
            }
            
            CreateChart();
        }

        private void foo(int days)
        {
            DateTime date1, date2;

            if (days > 0)
            {
                secondDate = DateTime.Now;
                firstDate = secondDate.AddDays(-days + 1);
            }
            else if (days == 0)
            {
                secondDate = DateTime.Now.AddDays(-1);
                firstDate = secondDate;
            }
            else

            SummaryUserControl.days = days;

            outlet = MainWindow.httpConnection.GetMicroMarketsData(firstDate, secondDate);
            productSats = MainWindow.httpConnection.GetMicroMarketsProductsData(firstDate, secondDate);

            labelProceedsLast_Value.Text = ((int)outlet.lastProceedsSummary).ToString();
            labelAVGReceiptLast_Value.Text = ((int)(outlet.lastProceedsSummary / outlet.lastCountSummary)).ToString();
            labelCointPositionsLast_Value.Text = outlet.lastCountSummary.ToString();

            if (days == 1)
            {
                labelProceedsNow_Value.Text = outlet.proceedsSummary.ToString() + " " + (int)((outlet.proceedsSummary / outlet.lastNowProceedsSummary - 1) * 100) + "%";
                labelProceedsLastNow_Value.Text = ((int)outlet.lastNowProceedsSummary).ToString();

                labelAVGReceiptNow_Value.Text = ((int)(outlet.proceedsSummary / outlet.countSummary)).ToString() + " " + (int)(((outlet.proceedsSummary / outlet.countSummary) / (outlet.lastNowProceedsSummary / outlet.lastNowCountSummary) - 1) * 100) + "%"; ;
                labelAVGReceiptLastNow_Value.Text = ((int)(outlet.lastNowProceedsSummary / outlet.lastNowCountSummary)).ToString();

                labelCointPositionsNow_Value.Text = outlet.countSummary.ToString() + " " + (int)((outlet.countSummary * 1.0 / outlet.lastNowCountSummary - 1) * 100) + "%"; ;
                labelCointPositionsLastNow_Value.Text = outlet.lastNowCountSummary.ToString();
            }
            else // 0 - скрыть
            {
                labelProceedsNow_Value.Text = outlet.proceedsSummary.ToString() + " " + (int)((outlet.proceedsSummary / outlet.lastProceedsSummary - 1) * 100) + "%";
                labelProceedsLastNow_Value.Text = "0";

                labelAVGReceiptNow_Value.Text = ((int)(outlet.proceedsSummary / outlet.countSummary)).ToString() + " " + (int)(((outlet.proceedsSummary / outlet.countSummary) / (outlet.lastProceedsSummary / outlet.lastCountSummary) - 1) * 100) + "%"; ;
                labelAVGReceiptLastNow_Value.Text = "0";

                labelCointPositionsNow_Value.Text = outlet.countSummary.ToString() + " " + (int)((outlet.countSummary * 1.0 / outlet.lastCountSummary - 1) * 100) + "%"; ;
                labelCointPositionsLastNow_Value.Text = "0";
            }
            
            Label[] labelsPoints = new Label[] { labelPoint1, labelPoint1_Value, labelPoint2, labelPoint2_Value, labelPoint3, labelPoint5_Value, labelPoint5, labelPoint4_Value, labelPoint4, labelPoint3_Value };

            for (int i = 0; i < labelsPoints.Length / 2; i++)
            {
                labelsPoints[2 * i].Text = outlet.outlet.ElementAt(i).Key;
                labelsPoints[2 * i + 1].Text = outlet.outlet.ElementAt(i).Value.proceeds.ToString();
            }

            Label[] labelsPositions = new Label[] { labelPos1, labelPos1_Value, labelPos2, labelPos2_Value, labelPos3, labelPos3_Value, labelPos4, labelPos4_Value, labelPos5, labelPos5_Value };

            for (int i = 0; i < labelsPositions.Length / 2; i++)
            {
                labelsPositions[2 * i].Text = productSats.outlet.ElementAt(i).Key;
                labelsPositions[2 * i + 1].Text = productSats.outlet.ElementAt(i).Value.proceeds.ToString();
            }
            switch (days)
            {
                case 1: days = 1; break;
                case 7: days = 5; break;
                case 31: days = 21; break;
                default: days = secondDate.Subtract(firstDate).Days + 1; break;
            }         
            SummaryUserControl.days = days;
        }

        private void CreateChart()
        {
            int greenCount = 0; 
            int redCount = 0;

            foreach (var item in outlet.outlet)
            {
                if (item.Value.proceeds > days * MainWindow.target_MicroMarket)
                {
                    greenCount++;
                }
                else if (item.Value.proceeds < days * MainWindow.breakEven_MicroMarket)
                {
                    redCount++;
                }
            }

            chart1.Series[0].Points.Clear();

            chart1.Series[0].Label = "#PERCENT{P1}";
            chart1.Series[0].LegendText = "#VALX";
            chart1.Legends[0].Docking = Docking.Left;
            chart1.Legends[0].Alignment = StringAlignment.Center;

            chart1.Series[0].Points.Add(greenCount);
            chart1.Series[0].Points[0].Color = Color.FromArgb(18, 138, 77);
            chart1.Series[0].Points[0].LegendText = "В целевой\nвыручке";

            chart1.Series[0].Points.Add(redCount);
            chart1.Series[0].Points[1].Color = Color.FromArgb(190, 49, 49);
            chart1.Series[0].Points[1].LegendText = "Убыточные\nточки";

            chart1.Series[0].Points.Add(outlet.outlet.Count - greenCount - redCount);
            chart1.Series[0].Points[2].Color = Color.FromArgb(200, 200, 200);
            chart1.Series[0].Points[2].LegendText = "Безубыточные\nточки";
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            AddUserControl(new GraphControl(ref panel, STATS_TYPE.Proceeds));
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            AddUserControl(new GraphControl(ref panel, STATS_TYPE.AvgCheck));
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            AddUserControl(new ProductStatsTable(ref panel, STATS_TYPE.Outlets));
        }    

        private void panel5_Click(object sender, EventArgs e)
        {
            AddUserControl(new ProductStatsTable(ref panel, STATS_TYPE.Positions));
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!isSelectingRange)
            {
                firstDate = e.Start;
                labelDate1.Text = e.Start.ToString("d");
            }
            else
            {
                secondDate = e.Start;
                labelDate2.Text = "-" + e.Start.ToString("d");
            }
        }

        private void labelDate_Click(object sender, EventArgs e)
        {
            Label labelDate = sender as Label;
           
            monthCalendar1.Location = new Point(labelDate.Location.X - monthCalendar1.Width / 2, labelDate.Location.Y + 50);
            
            if (labelDate == labelDate2) isSelectingRange = true;
            else isSelectingRange = false;
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((CustomBTN)sender).TextColor = Color.White;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((CustomBTN)sender).TextColor = Color.FromArgb(35, 39, 53);
            if (btn != null) btn.ForeColor = Color.White;
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.FromArgb(18, 138, 77);
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.FromArgb(22, 173, 96);
        }
    }
}
