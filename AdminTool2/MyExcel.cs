using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace AdminTool2
{
    public class MyExcel
    {
        public static DataTable microMarketDataTable = new DataTable();
        public static DataTable cofeeDataTable = new DataTable();
        public static DataTable kioskDataTable = new DataTable();

        private string path;
        private Excel.Application app;
        private Excel.Workbook workBook;
        private Excel.Worksheet sheet;
        private Excel.Range range;

        private Table tableData;

        public MyExcel(string path)
        {
            this.path = path;

            app = new Excel.Application //до этого было просто new()
            {
                SheetsInNewWorkbook = 1
            };
            workBook = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
        }

        public MyExcel() { }

        public void Open(string path)
        {
            app = new Excel.Application();
            workBook = app.Workbooks.Open(path);                                           
            sheet = workBook.Worksheets[1];
        }

        public void Save()
        {
            app.Application.ActiveWorkbook.SaveAs(path);
        }

        public void CreateReport(string path)
        {
            app = new Excel.Application
            {
                SheetsInNewWorkbook = 3
            };
            workBook = app.Workbooks.Add(Type.Missing);

            int days = 1;

            sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Микромаркеты";
            DataTableToExcel(ref microMarketDataTable, ref MainWindow.target_MicroMarket, ref MainWindow.breakEven_MicroMarket, ref days);

            sheet = (Excel.Worksheet)app.Worksheets.get_Item(2);
            sheet.Name = "Кофе";
            DataTableToExcel(ref cofeeDataTable, ref MainWindow.target_Coffee, ref MainWindow.breakEven_Coffee, ref days);

            sheet = (Excel.Worksheet)app.Worksheets.get_Item(3);
            sheet.Name = "Киоски";
            DataTableToExcel(ref kioskDataTable, ref MainWindow.target_Kiosk, ref MainWindow.breakEven_Kiosk, ref days);

            app.Application.ActiveWorkbook.SaveAs(path);
        }

        public void DataTableToExcel(ref DataTable dataTable, ref double targetValue, ref double breakEvenValue, ref int days)
        {
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                sheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
            }

            for (int i = 1; i <= dataTable.Rows.Count; i++)
            {
                for (int j = 1; j <= dataTable.Columns.Count; j++)
                {
                    sheet.Cells[i + 1, j] = dataTable.Rows[i - 1][j - 1];
                }
            }

            Excel.Range r1 = sheet.Cells[1, 1];
            Excel.Range r2 = sheet.Cells[dataTable.Rows.Count + 1, 4];
            range = sheet.get_Range(r1, r2);
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            r1 = sheet.Cells[1, 1];
            r2 = sheet.Cells[1, 4];
            range = sheet.get_Range(r1, r2);
            range.Cells.Font.Size = 13;
            range.Cells.Font.Bold = true;

            r1 = sheet.Cells[2, 1];
            r2 = sheet.Cells[dataTable.Rows.Count + 1, 1];
            range = sheet.get_Range(r1, r2);
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            range.EntireColumn.ColumnWidth = 38;

            range = sheet.Cells[1, 4];
            range.EntireColumn.ColumnWidth = 20;

            int greenCount = 0; int redCount = 0;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if ((int)dataTable.Rows[i][2] > targetValue * days)
                {
                    range = sheet.Cells[i + 2, 4];
                    range.Font.Color = ColorTranslator.ToOle(Color.Green);
                    greenCount++;
                }
                else if ((int)dataTable.Rows[i][2] < breakEvenValue * days)
                {
                    range = sheet.Cells[i + 2, 4];
                    range.Font.Color = ColorTranslator.ToOle(Color.Red);
                    redCount++;
                }
            }

            sheet.Cells[1, 6] = greenCount;
            sheet.Cells[2, 6] = redCount;
            sheet.Cells[3, 6] = dataTable.Rows.Count - greenCount - redCount;

            sheet.Cells[1, 5] = "В целевой выручке";
            sheet.Cells[2, 5] = "Убыточные точки";
            sheet.Cells[3, 5] = "Безубыточные точки";

            r1 = sheet.Cells[1, 5];
            r2 = sheet.Cells[3, 6];
            Excel.Range dataRange = sheet.get_Range(r1, r2);
            Excel.ChartObject chartObject = sheet.ChartObjects().Add(dataRange.Left, dataRange.Top, 300, 200);
            Excel.Chart chart = chartObject.Chart;
            chart.ChartType = Excel.XlChartType.xlPie;
            chart.SetSourceData(dataRange);

            chart.HasTitle = true;
            chart.ChartTitle.Text = "Структура портфеля ТП";

            Color[] colorArray = new Color[3] { Color.Green, Color.Red, Color.Gray };
            chart.SeriesCollection(1).HasDataLabels = true;

            for (int i = 1; i <= chart.SeriesCollection(1).Points().Count; i++)
            {
                chart.SeriesCollection(1).Points(i).Format.Fill.ForeColor.RGB = ColorTranslator.ToOle(colorArray[i - 1]);
                chart.SeriesCollection(1).Points(i).DataLabel.ShowPercentage = true;
                chart.SeriesCollection(1).Points(i).DataLabel.ShowValue = false;
            }
        }

        public void DataTableToExcel2(ref DataTable dataTable, ref double targetValue, ref double breakEvenValue, ref int days)
        {
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                sheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
            }

            for (int i = 1; i <= dataTable.Rows.Count; i++)
            {
                for (int j = 1; j <= dataTable.Columns.Count; j++)
                {
                    sheet.Cells[i + 1, j] = dataTable.Rows[i - 1][j - 1];
                }
            }

            Excel.Range r1 = sheet.Cells[1, 1];
            Excel.Range r2 = sheet.Cells[dataTable.Rows.Count + 1, 4];
            range = sheet.get_Range(r1, r2);
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            r1 = sheet.Cells[1, 1];
            r2 = sheet.Cells[1, 4];
            range = sheet.get_Range(r1, r2);
            range.Cells.Font.Size = 13;
            range.Cells.Font.Bold = true;

            r1 = sheet.Cells[2, 1];
            r2 = sheet.Cells[dataTable.Rows.Count + 1, 1];
            range = sheet.get_Range(r1, r2);
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            range.EntireColumn.ColumnWidth = 38;
        }

        public int Find(string name)
        {
            range = sheet.Cells.Find(name, Type.Missing, Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart);

            if (range != null) return range.Row;
            else return 0;
        }

        public void GetDataReport()
        {
            string[] arrayNames = new string[3] { "Микромаркеты", "Кофе", "Киоски" };
            DataTable[] dataTables = new DataTable[3] { microMarketDataTable, cofeeDataTable, kioskDataTable };

            for (int k = 0; k < dataTables.Length; k++)
            {
                dataTables[k].Columns.Add(arrayNames[k], typeof(string));
                dataTables[k].Columns.Add("Кол-во", typeof(int));
                dataTables[k].Columns.Add("Выручка", typeof(int));
                dataTables[k].Columns.Add("Выполненпие ПП", typeof(string));
            }

            int i = 10;
            while (sheet.Cells[i, 2].Value != "Киоск") i++;
            i++;

            while (sheet.Cells[i, 14].Value != null)
            {
                if (sheet.Cells[i, 2].Value.IndexOf("Микромаркет") != -1)
                {
                    microMarketDataTable.Rows.Add(sheet.Cells[i, 2].Value, (int)sheet.Cells[i, 12].Value, (int)sheet.Cells[i, 14].Value, (int)((double)sheet.Cells[i, 14].Value / MainWindow.target_MicroMarket * 100) + "%");
                }
                else if (sheet.Cells[i, 2].Value.IndexOf("_КОФЕ") != -1 || sheet.Cells[i, 2].Value.IndexOf("_Кофе") != -1)
                {
                    cofeeDataTable.Rows.Add(sheet.Cells[i, 2].Value, (int)sheet.Cells[i, 12].Value, (int)sheet.Cells[i, 14].Value, (int)((double)sheet.Cells[i, 14].Value / MainWindow.target_Coffee * 100) + "%");
                }
                else
                {
                    kioskDataTable.Rows.Add(sheet.Cells[i, 2].Value, (int)sheet.Cells[i, 12].Value, (int)sheet.Cells[i, 14].Value, (int)((double)sheet.Cells[i, 14].Value / MainWindow.target_Kiosk * 100) + "%");
                }

                i++;
            }
        }

        public int GetColumnsCount()
        {
            return sheet.Cells[1, sheet.Columns.Count].End[Excel.XlDirection.xlToLeft].Column + 1;
        }

        public dynamic GetCellsValue(int row, int column)
        {
            return sheet.Cells[row, column].Value;
        }

/*        public void Copy(MyExcel myExcel)
        {
            app = myExcel.app;
            workBook = myExcel.workBook;
            sheet = myExcel.sheet;
        }*/

        public void CopyTo(string path)
        {
            app.Application.ActiveWorkbook.SaveAs(path);
        }

        public void Create(Table tableData)
        {
            this.tableData = tableData;

            AddColumns();
            AddRows();
            AddItems();
            SetVisual();
            SetFormules();

            app.Application.ActiveWorkbook.SaveAs(path);
        }

        public void Close()
        {
            app.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }

        private void SetVisual()
        {
            Excel.Range r1 = sheet.Cells[2, 1];
            Excel.Range r2 = sheet.Cells[tableData.product.Count + 3, 2];
            range = sheet.get_Range(r1, r2);

            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.EntireColumn.ColumnWidth = 15;
            range.Cells.Font.Name = "Arial";
            range.Cells.Font.Size = 10;
            range.Cells.Font.Bold = true;

            r1 = sheet.Cells[2, 2];
            range = sheet.get_Range(r1, r2);
            range.EntireColumn.ColumnWidth = 60;
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            r1 = sheet.Cells[1, 3];
            r2 = sheet.Cells[1, tableData.company.Count + 4];
            range = sheet.get_Range(r1, r2);
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.EntireRow.RowHeight = 180;
            range.Cells.Font.Name = "Arial";
            range.Cells.Font.Size = 15;
            range.Cells.Font.Bold = true;
            range.Cells.Orientation = 90;

            r1 = sheet.Cells[2, 3];
            r2 = sheet.Cells[tableData.product.Count + 3, tableData.company.Count + 4];
            range = sheet.get_Range(r1, r2);
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.Cells.Font.Name = "Arial";
            range.Cells.Font.Size = 12;
            range.Cells.Font.Bold = true;

            range = sheet.Cells[tableData.product.Count + 2, 2]; // упростить
            range.Font.Size = 15;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            range = sheet.Cells[tableData.product.Count + 3, 2];
            range.Font.Size = 15;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
        }

        private void SetFormules()
        {
            sheet.Cells[1, 3] = "Итого:";

            for (int i = 0; i < tableData.product.Count; i++)
            {
                sheet.Cells[i + 2, 3].FormulaLocal = $"=СУММ(RC[1]:RC[{tableData.company.Count}])";
            }

            sheet.Cells[tableData.product.Count + 2, 2] = "Итого (по кол-ву):";

            for(int i = 3; i < tableData.company.Count + 4; i++)
            {
                sheet.Cells[tableData.product.Count + 2, i].FormulaLocal = $"=СУММ(R[-{tableData.product.Count}]C:R[-1]C)";
            }

            sheet.Cells[1, tableData.company.Count + 4] = "Реком. кол-во";

            int j = 2;
            foreach (var item in tableData.product)
            {
                sheet.Cells[j, tableData.company.Count + 5] = item.Value.price;
                sheet.Cells[j, tableData.company.Count + 4] = item.Value.count;
                j++;
            }
            
            sheet.Cells[tableData.product.Count + 3, 2] = "Итого (по выручке):";

            for (int i = 4; i < tableData.company.Count + 4; i++)
            {
                sheet.Cells[tableData.product.Count + 3, i].FormulaLocal = $"=СУММПРОИЗВ(R[-{tableData.product.Count + 1}]C:R[-2]C;R[-{tableData.product.Count + 1}]C{tableData.company.Count + 5}:R[-2]C{tableData.company.Count + 5})";
            }
        }

        private void AddRows()
        {
            int i = 2;

            foreach (var item in tableData.product)
            {
                sheet.Cells[i, 1] = item.Value.nameProvider;
                sheet.Cells[i, 2] = item.Key;

                tableData.product[item.Key].row = i;

                i++;
            }
        }

        private void AddColumns()
        {
            int j = 4;

            foreach (var item in tableData.company)
            {
                sheet.Cells[1, j] = item.Key;
                j++;
            }
        }

        private void AddItems() 
        {
            int row;
            int i = 4;

            foreach (var companyName in tableData.company.Keys.ToList())
            {
                if (tableData.colorMapCompany.ContainsKey(companyName) && tableData.colorMapCompany[companyName] != Color.White)
                {
                    (sheet.Cells[1, i] as Excel.Range).Interior.Color = tableData.colorMapCompany[companyName];
                }

                foreach (var productName in tableData.company[companyName].Keys.ToList())
                {
                    row = tableData.product[productName].row;
                    sheet.Cells[row, i] = tableData.company[companyName][productName].count;

                    if (tableData.colorMapProduct.ContainsKey(productName))
                    {
                        (sheet.Cells[row, 2] as Excel.Range).Interior.Color = tableData.colorMapProduct[productName];
                    }
                    if (tableData.company[companyName][productName].color)
                    {
                        (sheet.Cells[row, i] as Excel.Range).Interior.Color = Color.Red;
                    }
                }
                i++;
            }
        }
    }
}
