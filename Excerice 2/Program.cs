using System;
using System.IO;
using System.Net;
using System.Text;

namespace Excerice_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string url;
            string check = "htpps://";
            Console.WriteLine("Enter a url to see contents:");
            url = Console.ReadLine();

            if (string.Compare(check, url.Substring(0, 8)) != 0)
            {
                url = "https://" + url;
            }
            WebRequest wb = WebRequest.Create(url);
            WebResponse rp = wb.GetResponse();
            StreamReader reader = new StreamReader(rp.GetResponseStream(), Encoding.ASCII);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
