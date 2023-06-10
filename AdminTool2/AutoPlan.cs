using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTool2
{
    public class AutoPlan
    {

        private static string loadFilePath = "C:\\Users\\AdraliK\\Desktop\\load.xlsx";

        public static void Create(string path)
        {
            MyExcel myExcel = new MyExcel(path);
            Table tableData = new Table();

            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                tableData = MainWindow.httpConnection.GetData(DateTime.Now.AddDays(-4).ToString("d"));

                foreach (var companyName in tableData.company.Keys.ToList()) 
                {
                    foreach (var productName in tableData.company[companyName].Keys.ToList())
                    {
                        tableData.company[companyName][productName].count += 
                            (int)Math.Ceiling(tableData.company[companyName][productName].count * MainWindow.PERCENT_VALUE);
                    }
                }

                myExcel.Create(tableData);
                myExcel.CopyTo(loadFilePath);
                myExcel.Close();
            }
            else
            {
                MyExcel loadExcel = new MyExcel();
                loadExcel.Open(loadFilePath);

                tableData = MainWindow.httpConnection.GetData(DateTime.Now.ToString("d"));

                foreach (var item in tableData.company)
                {
                    tableData.colorMapCompany[item.Key] = Color.Green;
                }

                for (int i = 4; i < loadExcel.GetColumnsCount(); i++)
                {
                    string nameCompany = loadExcel.GetCellsValue(1, i);

                    if (tableData.company.ContainsKey(nameCompany))
                    {
                        tableData.colorMapCompany[nameCompany] = Color.White;

                        foreach (var nameProduct in tableData.company[nameCompany].Keys.ToList())
                        {
                            int row = loadExcel.Find(nameProduct);

                            if (row != 0)
                            {
                                if (loadExcel.GetCellsValue(row, i) != null)
                                {
                                    if (((int)loadExcel.GetCellsValue(row, i) - tableData.company[nameCompany][nameProduct].count) <= 0)
                                    {
                                        tableData.company[nameCompany][nameProduct].count += 
                                            (int)Math.Ceiling(tableData.company[nameCompany][nameProduct].count * MainWindow.PERCENT_VALUE);
                                    }
                                    else if ((tableData.company[nameCompany][nameProduct].count * 1.0 / (int)loadExcel.GetCellsValue(row, i)) <= 0.5)
                                    {
                                        tableData.company[nameCompany].Remove(nameProduct);
                                    }
                                }
                                else
                                {
                                    tableData.company[nameCompany][nameProduct].color = true;
                                }
                            }
                            else
                            {
                                tableData.colorMapProduct[nameProduct] = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        tableData.company[nameCompany] = new Dictionary<string, Table.Prod>();
                        tableData.colorMapCompany[nameCompany] = Color.Red;
                    }
                }

                foreach (var item in tableData.product)
                {
                    int row = loadExcel.Find(item.Key);

                    if (row != 0)
                    {
                        if ((int)loadExcel.GetCellsValue(row, 3) - item.Value.count <= 0)
                        {
                            item.Value.count += (int)Math.Ceiling(item.Value.count * MainWindow.PERCENT_VALUE);
                        }
                        else if ((item.Value.count * 1.0 / (int)loadExcel.GetCellsValue(row, 3) * 1.0) > 0.5)
                        {
                            item.Value.count = (int)Math.Ceiling(((int)loadExcel.GetCellsValue(row, 3) + item.Value.count) * 1.0 / 2);
                        }
                        else if ((item.Value.count * 1.0 / (int)loadExcel.GetCellsValue(row, 3) * 1.0) <= 0.5)
                        {
                            item.Value.count = 0;
                        }
                    }
                }

                loadExcel.Close();

                myExcel.Create(tableData);
                //myExcel1.CopyTo("C:\\Users\\AdraliK\\Desktop\\load.xlsx");
                myExcel.Close();
            }
        }

        public static void DownLoadReport(string path)
        {
            MyExcel myExcel = new MyExcel(path);
            Table tableData = new Table();

            tableData = MainWindow.httpConnection.GetData("23.01.2023");

            //tableData = MainWindow.httpConnection.GetData(DateTime.Now.ToString("d"));

            myExcel.Create(tableData);
            myExcel.Close();
        }

    }
}
