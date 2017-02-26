using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembliesAndNamepaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://msdn.microsoft.com");

            Console.WriteLine(reply);

            File.WriteAllText(@"C:\Users\Daniel\Documents\Visual Studio 2015\Projects\AssembliesAndNamepaces\WriteText.txt", reply);

            Console.ReadKey();
        }
    }
}
