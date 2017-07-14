using System;
using System.IO;
using System.Net;

namespace riotAPI_teste
{
    class HttpRequest
    {
        public HttpRequest(){}
        /// <summary>
        /// Requests data from RIOT API
        /// </summary>
        /// <param name="url"> API url</param>
        /// <returns>StreamReader object with json string</returns>
        public StreamReader getJson(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            try
            {
                WebResponse response = request.GetResponse();
                StreamReader document = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
                return document;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
