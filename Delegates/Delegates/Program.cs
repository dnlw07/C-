using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // tworzy obiekt Car oraz ustawia nazwę obiektu na Car1
            Car car = new Car
            {
                Name = "Car1"
            };

            // podstawia referencję do metody, która jest w stanie obsłuzyc to zdarzenie, inczej będzie null
            car.NameChanged = new NameChangeDelegate(Car_NameChanged);
            
            // zmiana nazwy na Car2
            car.Name = "Car2";

            Console.ReadKey();
        }

        // metoda zostanie wywołana z poziomu pola znajdujecego się klasie cars
        private static void Car_NameChanged(string oldName, string newName)
        {
            Console.WriteLine("Zmiana z {0} na {1}", oldName, newName);
        }
    }
}
