using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// pełna data i godzina
            //DateTime myValue = DateTime.Now;

            //// wyświetla pełną datę i godzinę
            //Console.WriteLine(myValue.ToString());

            //// wyświetla krótką datę
            //Console.WriteLine(myValue.ToShortDateString());

            //// wyświetla krótką godzinę
            //Console.WriteLine(myValue.ToShortTimeString());

            //// wyświetla długą godzinę
            //Console.WriteLine(myValue.ToLongTimeString());

            //// dodawanie dni
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            //// dodawanie godzin
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            //// dodawanie godzin
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //// Wyświetla jedynie miesiąć
            //Console.WriteLine(myValue.Month);

            //// Wprowadzanie konkretnej daty
            //DateTime myBirthday = new DateTime(1989, 7, 29);
            
            // Funkcja analizje i rozbija (parsuje) wstawioną datę ze wartości string na date time
            DateTime myBirthday = DateTime.Parse("29.07.1989");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}