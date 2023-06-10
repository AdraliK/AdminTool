using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminTool2
{
    public partial class ProductStatsTable : UserControl
    {
        private Panel panel;
        private SummaryUserControl.STATS_TYPE type;
        private DataTable dataTable;

        public ProductStatsTable(ref Panel panel, SummaryUserControl.STATS_TYPE type)
        {
            InitializeComponent();
            this.panel = panel;
            this.type = type;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            panel.Controls.Remove(this);
        }

        private void ProductStatsTable_Load(object sender, EventArgs e)
        {
            int i = 1;
            dataTable = new DataTable();

            if (type == SummaryUserControl.STATS_TYPE.Positions)
            {
                for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                {
                    dataTable.Columns.Add(dataGridView1.Columns[j + 1].HeaderText, typeof(object));
                }
                foreach (var item in SummaryUserControl.productSats.outlet)
                {
                    dataGridView1.Rows.Add(i++, item.Key, item.Value.count, (int)item.Value.proceeds);
                    dataTable.Rows.Add(item.Key, item.Value.count, (int)item.Value.proceeds);
                }
            }
            else if (type == SummaryUserControl.STATS_TYPE.Outlets)
            {
                dataGridView1.Columns[1].HeaderText = "Наименование точки";
                dataGridView1.Columns.Add("ProcentValue", "Выполнение ПП");
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                {
                    dataTable.Columns.Add(dataGridView1.Columns[j + 1].HeaderText, typeof(object));
                }
                foreach (var item in SummaryUserControl.outlet.outlet)
                {
                    dataGridView1.Rows.Add(i++, item.Key, item.Value.count, (int)item.Value.proceeds, (int)(item.Value.proceeds / (SummaryUserControl.days * MainWindow.target_MicroMarket) * 100) + "%");
                    dataTable.Rows.Add(item.Key, item.Value.count, (int)item.Value.proceeds, (int)(item.Value.proceeds / (SummaryUserControl.days * MainWindow.target_MicroMarket) * 100) + "%");
                }

                for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if ((int)dataGridView1[3, i].Value > SummaryUserControl.days * MainWindow.target_MicroMarket)
                    {
                        dataGridView1[4, i].Style.ForeColor = Color.Green;
                    }
                    else if ((int)dataGridView1[3, i].Value < SummaryUserControl.days * MainWindow.breakEven_MicroMarket)
                    {
                        dataGridView1[4, i].Style.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyExcel myExcel = new MyExcel("C:\\Users\\AdraliK\\Desktop\\report.xlsx");

            if (type == SummaryUserControl.STATS_TYPE.Positions)
            {
                myExcel.DataTableToExcel2(ref dataTable, ref MainWindow.target_MicroMarket, ref MainWindow.breakEven_MicroMarket, ref SummaryUserControl.days);
            }
            else if (type == SummaryUserControl.STATS_TYPE.Outlets)
            {
                myExcel.DataTableToExcel(ref dataTable, ref MainWindow.target_MicroMarket, ref MainWindow.breakEven_MicroMarket, ref SummaryUserControl.days);
            }

            myExcel.Save();
            myExcel.Close();
            dataTable.Clear();
        }

    }
}
