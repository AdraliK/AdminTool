using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdminTool2
{
    public class GetRequest
    {

        HttpWebRequest request;

        public Dictionary<string, string> Headers { get; set; }

        public string adress { get; set; }
        public string Response { get; set; }
        public string Accept { get; set; }
        public string Host { get; set; }
        public string UserAgent { get; set; }
        public string Referer { get; set; }
        public WebProxy Proxy { get; set; }


        public GetRequest(string adress)
        {
            this.adress = adress;
            Headers = new Dictionary<string, string>();
        }

        public void Run()
        {
            request = (HttpWebRequest)WebRequest.Create(adress);
            request.Method = "GET";

            foreach (var pair in Headers)
            {
                request.Headers.Add(pair.Key, pair.Value);
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                if (stream != null) Response = new StreamReader(stream).ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Run(CookieContainer cookieContainer)
        {
            request = (HttpWebRequest)WebRequest.Create(adress);
            request.Method = "GET";
            request.CookieContainer = cookieContainer;
            request.Accept = Accept;
            request.Host = Host;
            request.Proxy = Proxy;
            request.UserAgent = UserAgent;
            request.Referer = Referer;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                if (stream != null) Response = new StreamReader(stream).ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
