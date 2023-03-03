using System.IO;
using System.Net.Sockets;
using System.Net;

namespace ioINIScanner.Network
{
    internal class HttpManager
    {
        public static string ReadWebText(string uriString)
        {
            string text = "";
            WebRequest request = null;
            WebResponse response = null;

            Stream resStream = null;
            StreamReader resReader = null;

            try
            {
                request = WebRequest.Create(uriString.Trim());
                response = request.GetResponse();
                resStream = response.GetResponseStream();
                resReader = new StreamReader(resStream);
                text = resReader.ReadToEnd();
            }
            catch
            {
                text = "";
            }
            finally
            {
                if (resReader != null)
                {
                    resReader.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
            }
            return text;
        }

        public static string GetMyIP()
        {
            string szip = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    szip = ip.ToString();
                }
            }
            return szip;
        }
    }
}
