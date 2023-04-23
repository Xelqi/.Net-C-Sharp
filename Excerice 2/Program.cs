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
            // This variable will be used to check if the given url has http:// 
            string check = "htpps://";
            Console.WriteLine("Enter a url to see contents:");
            url = Console.ReadLine();
            
            // The compare function checks if the entered url starts with http:// by using the Substring function
            // to get the first 8 parts of the entered string if they dont match it adds https:// to it
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
