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

namespace AdminTool2
{
    public partial class DataReportWindow : Form
    {
        double targetValue, breakEvenValue;

        int greenCount = 0;
        int redCount = 0;

        string path;

        public DataReportWindow(string path)
        {
            InitializeComponent();

            this.path = path;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                dataGridView.DataSource = MyExcel.microMarketDataTable;
                targetValue = MainWindow.target_MicroMarket;
                breakEvenValue = MainWindow.breakEven_MicroMarket;
            }
            else if (sender == button2)
            {
                dataGridView.DataSource = MyExcel.cofeeDataTable;
                targetValue = MainWindow.target_Coffee;
                breakEvenValue = MainWindow.breakEven_Coffee;
            }
            else if (sender == button3)
            {
                dataGridView.DataSource = MyExcel.kioskDataTable;
                targetValue = MainWindow.target_Kiosk;
                breakEvenValue = MainWindow.breakEven_Kiosk;
            }
            else return;

            dataGridView.Columns[0].Width = 200;

            ColorizeCells();
            CreateChart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Path.GetFileName(path);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyExcel myExcel = new MyExcel();
                myExcel.CreateReport(saveFileDialog1.FileName);
                myExcel.Close();
            }
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            ColorizeCells();
        }

        private void ColorizeCells()
        {
            greenCount = 0;
            redCount = 0;

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                if ((int)dataGridView[2, i].Value > targetValue)
                {
                    dataGridView[3, i].Style.ForeColor = Color.Green;
                    greenCount++;
                }
                else if ((int)dataGridView[2, i].Value < breakEvenValue)
                {
                    dataGridView[3, i].Style.ForeColor = Color.Red;
                    redCount++;
                }
            }

        }

        private void CreateChart()
        {
            chart1.Series[0].Points.Clear();

            chart1.Series[0].Points.Add(greenCount);
            chart1.Series[0].Points[0].Color = Color.Green;
            chart1.Series[0].Points[0].Label = (int)((greenCount * 1.0 / (dataGridView.Rows.Count - 1)) * 100) + "%";

            chart1.Series[0].Points.Add(redCount);
            chart1.Series[0].Points[1].Color = Color.Red;
            chart1.Series[0].Points[1].Label = (int)((redCount * 1.0 / (dataGridView.Rows.Count - 1)) * 100) + "%";

            chart1.Series[0].Points.Add(dataGridView.Rows.Count - greenCount - redCount - 1);
            chart1.Series[0].Points[2].Color = Color.Gray;
            chart1.Series[0].Points[2].Label = (int)(((dataGridView.Rows.Count - greenCount - redCount - 1) * 1.0 / (dataGridView.Rows.Count - 1)) * 100) + "%";
        }
    }
}
