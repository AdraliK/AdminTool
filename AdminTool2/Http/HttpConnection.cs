using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdminTool2
{
    public class HttpConnection
    {

        private CookieContainer cookieContainer = new CookieContainer();
        private GetRequest getRequest = new GetRequest("https://admin.inch.ru/user/login");
  
        int indexStart = 0, indexEnd = 0;
        int count = 0;
        string proceeds = "";

        public HttpConnection()
        {
            getRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
            getRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36 Edg/106.0.1370.42";
            getRequest.Host = "admin.inch.ru";

            getRequest.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Microsoft Edge\";v=\"106\", \"Not; A = Brand\";v=\"99\"");
            getRequest.Headers.Add("sec-ch-ua-mobile", "?0");
            getRequest.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            getRequest.Headers.Add("Sec-Fetch-Dest", "document");
            getRequest.Headers.Add("Sec-Fetch-Mode", "navigate");
            getRequest.Headers.Add("Sec-Fetch-Site", "same-origin");
            getRequest.Headers.Add("Sec-Fetch-User", "?1");
            getRequest.Headers.Add("Upgrade-Insecure-Requests", "1");

            getRequest.Run(cookieContainer);
        }

        public bool Login(string username, string password)
        {
            string csrf;

            int start = getRequest.Response.IndexOf("csrf-token") + 21;
            int end = getRequest.Response.IndexOf("==", start);
            csrf = getRequest.Response.Substring(start, end - start);

            PostRequest postRequest = new PostRequest("https://admin.inch.ru/user/login");
            postRequest.Data = $"_csrf={csrf}%3D%3D&LoginForm%5Busername%5D={username}&LoginForm%5Bpassword%5D={password}&login-button=";
            postRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
            postRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36 Edg/106.0.1370.42";
            postRequest.ContentType = "application/x-www-form-urlencoded";
            postRequest.Referer = "https://admin.inch.ru/user/login";
            postRequest.Host = "admin.inch.ru";

            postRequest.Headers.Add("Origin", "https://admin.inch.ru");
            postRequest.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Microsoft Edge\";v=\"106\", \"Not; A = Brand\";v=\"99\"");
            postRequest.Headers.Add("sec-ch-ua-mobile", "?0");
            postRequest.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            postRequest.Headers.Add("Sec-Fetch-Dest", "document");
            postRequest.Headers.Add("Sec-Fetch-Mode", "navigate");
            postRequest.Headers.Add("Sec-Fetch-Site", "same-origin");
            postRequest.Headers.Add("Sec-Fetch-User", "?1");
            postRequest.Headers.Add("Upgrade-Insecure-Requests", "1");

            postRequest.Run(cookieContainer);

            if (postRequest.Response.IndexOf("Вход") != -1) return false;

            return true;
        }

        public void RequestUnits(ref GetRequest getDataRequest)
        {
            getDataRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
            getDataRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36 Edg/106.0.1370.42";
            getDataRequest.Host = "admin.inch.ru";

            getDataRequest.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Microsoft Edge\";v=\"106\", \"Not; A = Brand\";v=\"99\"");
            getDataRequest.Headers.Add("sec-ch-ua-mobile", "?0");
            getDataRequest.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            getDataRequest.Headers.Add("Sec-Fetch-Dest", "document");
            getDataRequest.Headers.Add("Sec-Fetch-Mode", "navigate");
            getDataRequest.Headers.Add("Sec-Fetch-Site", "none");
            getDataRequest.Headers.Add("Sec-Fetch-User", "?1");
            getDataRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
        }

        private void FindCountAndProceeds(ref string response, ref int count, ref string proceeds, ref int indexStart, ref int indexEnd)
        {
            indexStart = response.IndexOf("<th>Итого</th>", indexEnd) + 4;
            indexStart = response.IndexOf("<th>", indexStart) + 4;
            indexEnd = response.IndexOf("</th>", indexStart);
            count = int.Parse(response.Substring(indexStart, indexEnd - indexStart).Trim());

            indexStart = response.IndexOf("<th>", indexEnd) + 4;
            indexStart = response.IndexOf("<th>", indexStart) + 4;
            indexStart = response.IndexOf("<th>", indexStart) + 4;
            indexEnd = response.IndexOf("</th>", indexStart);
            proceeds = response.Substring(indexStart, indexEnd - indexStart).Trim();
        }

        public Table GetData(string date)
        {
            GetRequest getDataRequest = new GetRequest($"https://admin.inch.ru/payments/index?id=2&PaymentForm%5Brange%5D={date}+00%3A00+-+{date}+23%3A59&PaymentForm%5Btype%5D=&PaymentForm%5Bmethod%5D=&PaymentForm%5BpointType%5D=&PaymentForm%5BpointId%5D=&PaymentForm%5Bgoods_id%5D=&PaymentForm%5Bpan%5D=&PaymentForm%5BappliedPromo%5D=&PaymentForm%5Bagg%5D=0&PaymentForm%5Bagg%5D=1&PaymentForm%5Bagg_by_days%5D=0&PaymentForm%5Bagg_by_devs%5D=0&PaymentForm%5Bagg_by_devs%5D=1&PaymentForm%5Bagg_by_supplier%5D=0&PaymentForm%5Bagg_by_supplier%5D=1&PaymentForm%5Bagg_by_category%5D=0&PaymentForm%5Bagg_by_goods%5D=0&PaymentForm%5Bagg_by_goods%5D=1&PaymentForm%5Bagg_by_method%5D=0&as=");
            RequestUnits(ref getDataRequest);

            getDataRequest.Run(cookieContainer);

            return ParseData(getDataRequest.Response);
        }

        private Table ParseData(string response)
        {
            string nameCompany, nameProvider, nameProduct, price;

            Table tableData = new Table();
            
            indexStart = response.IndexOf("/device/view?username");
            response = response.Substring(indexStart, response.Length - indexStart);
            response = response.Replace("&quot;", "\"");
            indexStart = response.IndexOf("/device/view?username");

            while (indexStart != -1)
            {
                indexStart = response.IndexOf("\">", indexStart) + 2;
                indexEnd = response.IndexOf("</a>", indexStart);
                nameCompany = response.Substring(indexStart, indexEnd - indexStart).Trim();

                indexStart = response.IndexOf("<td>", indexEnd) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                nameProvider = response.Substring(indexStart, indexEnd - indexStart).Trim();

                indexStart = response.IndexOf("<td>", indexEnd) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                nameProduct = response.Substring(indexStart, indexEnd - indexStart).Trim();

                indexStart = response.IndexOf("<td>", indexEnd) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                count = int.Parse(response.Substring(indexStart, indexEnd - indexStart).Trim());

                indexStart = response.IndexOf("<td>", indexEnd) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                price = response.Substring(indexStart, indexEnd - indexStart).Trim();

                if (!tableData.product.ContainsKey(nameProduct)) tableData.product[nameProduct] = 
                        new Table.Product(nameProvider, int.Parse(price.Substring(0, price.Length - 3)) / count, count);
                else tableData.product[nameProduct].count += count;

                if (!tableData.company.ContainsKey(nameCompany)) tableData.company[nameCompany] = 
                        new Dictionary<string, Table.Prod>() { { nameProduct, new Table.Prod(count) } };
                else try
                {
                    tableData.company[nameCompany].Add(nameProduct, new Table.Prod(count));
                }
                catch (Exception) { }

                indexStart = response.IndexOf("/device/view?username", indexStart);
            }

            return tableData;
        }

        public OutletStats GetMicroMarketsData(DateTime date1, DateTime date2)
        {
            GetRequest getDataRequest = new GetRequest($"https://admin.inch.ru/payments/index?id=2&PaymentForm%5Brange%5D={date1.ToString("d")}+00%3A00+-+{date2.ToString("d")}+23%3A59&PaymentForm%5Btype%5D=&PaymentForm%5Bmethod%5D=&PaymentForm%5BpointType%5D=&PaymentForm%5BpointId%5D=&PaymentForm%5Bgoods_id%5D=&PaymentForm%5Bpan%5D=&PaymentForm%5BappliedPromo%5D=&PaymentForm%5Bagg%5D=0&PaymentForm%5Bagg%5D=1&PaymentForm%5Bagg_by_days%5D=0&PaymentForm%5Bagg_by_devs%5D=0&PaymentForm%5Bagg_by_devs%5D=1&PaymentForm%5Bagg_by_supplier%5D=0&PaymentForm%5Bagg_by_category%5D=0&PaymentForm%5Bagg_by_goods%5D=0&PaymentForm%5Bagg_by_method%5D=0&as=");
            RequestUnits(ref getDataRequest);

            getDataRequest.Run(cookieContainer);

            OutletStats outletStats = ParseMicroMarketsData(getDataRequest.Response);

            if (SummaryUserControl.days == 0) SummaryUserControl.days = 1;

            date1 = date1.AddDays(-SummaryUserControl.days);
            date2 = date2.AddDays(-SummaryUserControl.days);

            string hoursNow, minutesNow;

            try
            {
                hoursNow = DateTime.Now.ToShortTimeString().Substring(0, 2);
                minutesNow = DateTime.Now.ToShortTimeString().Substring(3, 2);
            } 
            catch 
            {
                hoursNow = DateTime.Now.ToShortTimeString().Substring(0, 1);
                minutesNow = DateTime.Now.ToShortTimeString().Substring(2, 2);
            }

            getDataRequest.adress = $"https://admin.inch.ru/payments/index?id=2&PaymentForm%5Brange%5D={date1.ToString("d")}+00%3A00+-+{date2.ToString("d")}+23%3A59&PaymentForm%5Btype%5D=&PaymentForm%5Bmethod%5D=&PaymentForm%5BpointType%5D=&PaymentForm%5BpointId%5D=&PaymentForm%5Bgoods_id%5D=&PaymentForm%5Bpan%5D=&PaymentForm%5BappliedPromo%5D=&PaymentForm%5Bagg%5D=0&PaymentForm%5Bagg%5D=1&PaymentForm%5Bagg_by_days%5D=0&PaymentForm%5Bagg_by_devs%5D=0&PaymentForm%5Bagg_by_devs%5D=1&PaymentForm%5Bagg_by_supplier%5D=0&PaymentForm%5Bagg_by_category%5D=0&PaymentForm%5Bagg_by_goods%5D=0&PaymentForm%5Bagg_by_method%5D=0&as=";
            getDataRequest.Run(cookieContainer);

            ParseLastMicroMarketsData(getDataRequest.Response, ref outletStats);

            getDataRequest.adress = $"https://admin.inch.ru/payments/index?id=2&PaymentForm%5Brange%5D={date1.ToString("d")}+00%3A00+-+{date2.ToString("d")}+{hoursNow}%3A{minutesNow}&PaymentForm%5Btype%5D=&PaymentForm%5Bmethod%5D=&PaymentForm%5BpointType%5D=&PaymentForm%5BpointId%5D=&PaymentForm%5Bgoods_id%5D=&PaymentForm%5Bpan%5D=&PaymentForm%5BappliedPromo%5D=&PaymentForm%5Bagg%5D=0&PaymentForm%5Bagg%5D=1&PaymentForm%5Bagg_by_days%5D=0&PaymentForm%5Bagg_by_devs%5D=0&PaymentForm%5Bagg_by_devs%5D=1&PaymentForm%5Bagg_by_supplier%5D=0&PaymentForm%5Bagg_by_category%5D=0&PaymentForm%5Bagg_by_goods%5D=0&PaymentForm%5Bagg_by_method%5D=0&as=";
            getDataRequest.Run(cookieContainer);

            ParseLastNowMicroMarketsData(getDataRequest.Response, ref outletStats);

            outletStats.SortOutlet();

            return outletStats;
        }

        private OutletStats ParseMicroMarketsData(string response)
        {
            OutletStats outletStats = new OutletStats();

            string nameCompany;

            indexStart = response.IndexOf("/device/view?username");
            response = response.Substring(indexStart, response.Length - indexStart);
            indexStart = response.IndexOf("/device/view?username");

            while (indexStart != -1)
            {
                indexStart = response.IndexOf("\">", indexStart) + 2;
                indexEnd = response.IndexOf("</a>", indexStart);
                nameCompany = response.Substring(indexStart, indexEnd - indexStart).Trim();

                indexStart = response.IndexOf("<td>", indexEnd) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                count = int.Parse(response.Substring(indexStart, indexEnd - indexStart).Trim());

                indexStart = response.IndexOf("<td>", indexEnd) + 4;
                indexStart = response.IndexOf("<td>", indexStart) + 4;
                indexStart = response.IndexOf("<td>", indexStart) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                proceeds = response.Substring(indexStart, indexEnd - indexStart).Trim();

                outletStats.Add(nameCompany, count, int.Parse(proceeds.Substring(0, proceeds.Length - 3)));

                indexStart = response.IndexOf("/device/view?username", indexStart);
            }

            FindCountAndProceeds(ref response, ref count, ref proceeds, ref indexStart, ref indexEnd);

            outletStats.countSummary = count;
            outletStats.proceedsSummary = int.Parse(proceeds.Substring(0, proceeds.Length - 3));

            return outletStats;
        }
        private void ParseLastMicroMarketsData(string response, ref OutletStats outletStats)
        {
            indexEnd = 0;
            FindCountAndProceeds(ref response, ref count, ref proceeds, ref indexStart, ref indexEnd);

            outletStats.lastCountSummary = count;
            outletStats.lastProceedsSummary = int.Parse(proceeds.Substring(0, proceeds.Length - 3));
        }

        private void ParseLastNowMicroMarketsData(string response, ref OutletStats outletStats)
        {
            indexEnd = 0;
            FindCountAndProceeds(ref response, ref count, ref proceeds, ref indexStart, ref indexEnd);

            outletStats.lastNowCountSummary = count;
            outletStats.lastNowProceedsSummary = int.Parse(proceeds.Substring(0, proceeds.Length - 3));
        }

        public OutletStats GetMicroMarketsProductsData(DateTime date1, DateTime date2)
        {
            GetRequest getDataRequest = new GetRequest($"https://admin.inch.ru/payments/index?id=2&PaymentForm%5Brange%5D={date1.ToString("d")}+00%3A00+-+{date2.ToString("d")}+23%3A59&PaymentForm%5Btype%5D=&PaymentForm%5Bmethod%5D=&PaymentForm%5BpointType%5D=&PaymentForm%5BpointId%5D=&PaymentForm%5Bgoods_id%5D=&PaymentForm%5Bpan%5D=&PaymentForm%5BappliedPromo%5D=&PaymentForm%5Bagg%5D=0&PaymentForm%5Bagg%5D=1&PaymentForm%5Bagg_by_days%5D=0&PaymentForm%5Bagg_by_devs%5D=0&PaymentForm%5Bagg_by_supplier%5D=0&PaymentForm%5Bagg_by_category%5D=0&PaymentForm%5Bagg_by_goods%5D=0&PaymentForm%5Bagg_by_goods%5D=1&PaymentForm%5Bagg_by_method%5D=0&as=");
            RequestUnits(ref getDataRequest);

            getDataRequest.Run(cookieContainer);

            OutletStats productsStats = ParseMicroMarketsProductsData(getDataRequest.Response);

            productsStats.SortOutlet();

            return productsStats;
        }

        private OutletStats ParseMicroMarketsProductsData(string response)
        {
            OutletStats productsStats = new OutletStats();

            string nameCompany;

            indexStart = response.IndexOf("Уникальных плательщиков");
            response = response.Substring(indexStart, response.Length - indexStart);
            indexStart = response.IndexOf("Уникальных плательщиков");

            while (response.IndexOf("<tr>", indexStart) != -1)
            {
                indexStart = response.IndexOf("<td>", indexStart) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                nameCompany = response.Substring(indexStart, indexEnd - indexStart).Trim();

                indexStart = response.IndexOf("<td>", indexEnd) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                count = int.Parse(response.Substring(indexStart, indexEnd - indexStart).Trim());

                indexStart = response.IndexOf("<td>", indexEnd) + 4;
                indexStart = response.IndexOf("<td>", indexStart) + 4;
                indexStart = response.IndexOf("<td>", indexStart) + 4;
                indexEnd = response.IndexOf("</td>", indexStart);
                proceeds = response.Substring(indexStart, indexEnd - indexStart).Trim();

                productsStats.Add(nameCompany, count, int.Parse(proceeds.Substring(0, proceeds.Length - 3)));

                indexStart = response.IndexOf("<tr>", indexStart) + 4;
            }

            return productsStats;
        }

        private void AddDataFile(StreamWriter sw, ref string filePath, ref DateTime date1, ref DateTime date2)
        {
            GetRequest getDataRequest = new GetRequest($"https://admin.inch.ru/payments/index?id=2&PaymentForm%5Brange%5D={date1.ToString("d")}+00%3A00+-+{date1.ToString("d")}+23%3A59&PaymentForm%5Btype%5D=&PaymentForm%5Bmethod%5D=&PaymentForm%5BpointType%5D=&PaymentForm%5BpointId%5D=&PaymentForm%5Bgoods_id%5D=&PaymentForm%5Bpan%5D=&PaymentForm%5BappliedPromo%5D=&PaymentForm%5Bagg%5D=0&PaymentForm%5Bagg%5D=1&PaymentForm%5Bagg_by_days%5D=0&PaymentForm%5Bagg_by_devs%5D=0&PaymentForm%5Bagg_by_devs%5D=1&PaymentForm%5Bagg_by_supplier%5D=0&PaymentForm%5Bagg_by_category%5D=0&PaymentForm%5Bagg_by_goods%5D=0&PaymentForm%5Bagg_by_method%5D=0&as=");
            RequestUnits(ref getDataRequest);

            string response;
            int intproceeds = 0;


            using (sw)
            {
                while (date1 <= date2)
                {
                    getDataRequest.Run(cookieContainer);
                    response = getDataRequest.Response;

                    indexEnd = 0;

                    FindCountAndProceeds(ref response, ref count, ref proceeds, ref indexStart, ref indexEnd);

                    intproceeds = int.Parse(proceeds.Substring(0, proceeds.Length - 3));

                    System.Diagnostics.Debug.WriteLine($"{date1.ToString("d")}|{intproceeds}|{count}");
                    sw.WriteLine($"{date1.ToString("d")}|{intproceeds}|{count}");

                    date1 = date1.AddDays(1);

                    getDataRequest.adress = $"https://admin.inch.ru/payments/index?id=2&PaymentForm%5Brange%5D={date1.ToString("d")}+00%3A00+-+{date1.ToString("d")}+23%3A59&PaymentForm%5Btype%5D=&PaymentForm%5Bmethod%5D=&PaymentForm%5BpointType%5D=&PaymentForm%5BpointId%5D=&PaymentForm%5Bgoods_id%5D=&PaymentForm%5Bpan%5D=&PaymentForm%5BappliedPromo%5D=&PaymentForm%5Bagg%5D=0&PaymentForm%5Bagg%5D=1&PaymentForm%5Bagg_by_days%5D=0&PaymentForm%5Bagg_by_devs%5D=0&PaymentForm%5Bagg_by_devs%5D=1&PaymentForm%5Bagg_by_supplier%5D=0&PaymentForm%5Bagg_by_category%5D=0&PaymentForm%5Bagg_by_goods%5D=0&PaymentForm%5Bagg_by_method%5D=0&as=";

                }
            }
        }

        public void LoadData(int days)
        {
            string filePath = "..\\..\\Resourses\\data.txt";

            if (!File.Exists(filePath))
            {
                DateTime date2 = DateTime.Now;
                DateTime date1 = date2.AddDays(-days + 1);

                AddDataFile(File.CreateText(filePath), ref filePath, ref date1, ref date2);
            }
            else
            {
                string lastString = File.ReadLines(filePath).Last();

                if (lastString.StartsWith(DateTime.Now.ToString("d"))) return;

                DateTime date1 = DateTime.ParseExact(lastString.Substring(0, lastString.IndexOf("|")), "dd.MM.yyyy", null).AddDays(1);
                DateTime date2 = DateTime.Now;

                AddDataFile(File.AppendText(filePath), ref filePath, ref date1, ref date2);
            }
        }
    }
}
