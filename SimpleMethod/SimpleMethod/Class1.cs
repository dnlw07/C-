using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        // Metoda główna, w której są referencje do innych metod
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            DisplayResult(ReverseString(firstName),
                          ReverseString(lastName),
                          ReverseString(city));

            Console.ReadLine();

        }

        // Metoda odwracająca łańcuchy znaków wspak
            /* INPUT: string message, cokolwiek zostanie wczytane do pamięci 
             * (name, lastName i city) zostane nazwane jako "string mesage" 
             * i przemielone przez tą metodę 
             * OUTPUT: przekazuje dalej przemielony string
             */
        private static string ReverseString(string message)
        {
            // zamienia string na array
            char[] messageArray = message.ToCharArray();
            // odwraca kolejność liter
            Array.Reverse(messageArray);
            // zamienia array na string
            return String.Concat(messageArray);
        }

        // Metoda wyświetlająca wyniki
        private static void DisplayResult(string reversedFirstName, 
                                          string reversedLastName, 
                                          string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));
        }

        // Metoda wyświetlająca wyniki
        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }
    }
}
