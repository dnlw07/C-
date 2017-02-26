using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MyCodeLibary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        { 
            string reply = GetWebPage(url);
            
            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
        
        
        // C:\Users\Daniel\Documents\Visual Studio 2015\Projects\MyCodeLibary
    }
}
