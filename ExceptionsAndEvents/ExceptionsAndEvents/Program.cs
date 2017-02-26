using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myTab = new int[2];
                myTab[0] = 1;
                myTab[1] = 2;
                int element = myTab[10];
            }
            // przy uwzglednianiu wyjątków należy podawać jak najbardziej precyzyjnie rodzaj wyjątku jaki moży wystąpić...
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            // ... jednak, na koniec zawsze warto posłużyć się ogólną klasą uwzględniającą wyjątki nieprzewidziane wyjątki
            catch (Exception exception)
            {
                Console.WriteLine("Other error: " + exception.Message);
            }
            // podaje się instrukcje, które mają zostać wykonane pomimo wystąpienia wyjątku 
            // stosuje się w przypadku bardziej złożonych programów
            finally
            {
                // przykładowo przerwanie strumieniowania, w przypadku wystąpienia błędu konwersji
            }

            Console.ReadKey();
        }
    }
}
