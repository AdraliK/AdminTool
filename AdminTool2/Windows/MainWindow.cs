using AdminTool2;
using AdminTool2.MyControls;
using AdminTool2.Windows;
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

using Excel = Microsoft.Office.Interop.Excel;

namespace AdminTool2
{

    public partial class MainWindow : Form
    {
        public const double PERCENT_VALUE = 0.25;

        public static double target_MicroMarket;
        public static double breakEven_MicroMarket;

        public static double target_Coffee;
        public static double breakEven_Coffee;

        public static double target_Kiosk;
        public static double breakEven_Kiosk;

        public static HttpConnection httpConnection;
        private LoginWindow loginWindow;


        public MainWindow(HttpConnection httpConnection, LoginWindow loginWindow)
        {
            InitializeComponent();
            MainWindow.httpConnection = httpConnection;
            this.loginWindow = loginWindow;
            //httpConnection = new HttpConnection();
            //httpConnection.Login("adremova", "SEGeqwun831nqw1j");

            string[] configLines = File.ReadAllLines(ConfiguringWindow.configFilePath);

            target_MicroMarket = int.Parse(configLines[0]);
            breakEven_MicroMarket = int.Parse(configLines[1]);

            target_Coffee = int.Parse(configLines[2]);
            breakEven_Coffee = int.Parse(configLines[3]);

            target_Kiosk = int.Parse(configLines[4]);
            breakEven_Kiosk = int.Parse(configLines[5]);

            AddUserControl(new SummaryUserControl(ref panel1));

            httpConnection.LoadData(100);
        }


        private void configStripMenu_Click(object sender, EventArgs e)
        {
            ConfiguringWindow window = new ConfiguringWindow();
            window.Show();
        }

        private void buttonAutoPlan_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday) saveFileDialog1.FileName = "Заказ на " + DateTime.Now.AddDays(3).ToString("d") + ".xlsx";
            else saveFileDialog1.FileName = "Заказ на " + DateTime.Now.AddDays(1).ToString("d") + ".xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                AutoPlan.Create(saveFileDialog1.FileName);
            }
        }

        private void buttonDownloadReport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Стата за " + DateTime.Now.ToString("d") + ".xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AutoPlan.DownLoadReport(saveFileDialog1.FileName);
            }
        }

        private void buttonSaveAutoPlan_Click(object sender, EventArgs e) //Предотварить ошибку импорта неподходящих файлов
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonCreateReport_Click(object sender, EventArgs e) //Предотварить ошибку импорта неподходящих файлов
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyExcel myExcel = new MyExcel();
                myExcel.Open(openFileDialog1.FileName);

                myExcel.GetDataReport();

                //DataReportWindow window = new DataReportWindow(openFileDialog1.FileName);
                //window.Show();

                AddUserControl(new DataReportUserControl(openFileDialog1.FileName));

                myExcel.Close();
            } 
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginWindow.Close();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((CustomBTN)sender).TextColor = Color.White;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((CustomBTN)sender).TextColor = Color.FromArgb(13, 36, 19);
        }
    }
}
