using System;
using System.IO;
using System.Net;
using System.Text;

namespace IzsekovanjeRondelic.Helper
{
    class RestCall
    {
        public  string getRest(string url)
        {
            var podatki = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    podatki = reader.ReadToEnd();
                    Console.WriteLine(podatki);
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                }
                throw;
            }

            return podatki;
        }
    }
}
