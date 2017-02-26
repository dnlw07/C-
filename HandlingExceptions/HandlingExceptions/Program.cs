using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Daniel\Documents\Visual Studio 2015\Projects\HandlingExceptions\github.txt");
                Console.WriteLine(content);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem: ");
                Console.WriteLine("Make sure if file in named correctly.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem: ");
                Console.WriteLine("Make sure if the directory exists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem: ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Closing application now...");
            }
            Console.ReadKey();

        }
    }
}
