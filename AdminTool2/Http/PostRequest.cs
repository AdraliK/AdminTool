using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdminTool2
{
    public class PostRequest
    {

        HttpWebRequest request;
        string adress;

        public Dictionary<string, string> Headers { get; set; }

        public string Response { get; set; }
        public string Accept { get; set; }
        public string Host { get; set; }
        public string ContentType { get; set; }
        public string Data { get; set; }
        public string UserAgent { get; set; }
        public string Referer { get; set; }
        public WebProxy Proxy { get; set; }


        public PostRequest(string adress)
        {
            this.adress = adress;
            Headers = new Dictionary<string, string>();
        }

        public void Run(CookieContainer cookieContainer)
        {
            request = (HttpWebRequest)WebRequest.Create(adress);
            request.Method = "POST";
            request.CookieContainer = cookieContainer;
            request.Accept = Accept;
            request.Host = Host;
            request.Proxy = Proxy;
            request.ContentType = ContentType;
            request.UserAgent = UserAgent;
            request.Referer = Referer;

            byte[] sentData = Encoding.UTF8.GetBytes(Data);
            request.ContentLength = sentData.Length;
            Stream sentStream = request.GetRequestStream();
            sentStream.Write(sentData, 0, sentData.Length);
            sentStream.Close();

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                if (stream != null) Response = new StreamReader(stream).ReadToEnd();
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
