using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // klasa Car o nazwie myCar = utwórz nowa instancje (obiekt) klasy Car i wstaw do pamięci
            Car car = new Car();

            // hardcoded dane samochodu 
            car.Make = "Oldsmobile";
            car.Model = "Cutlas Supreme";
            car.Year = 1986;
            car.Color = "Silver";

            // wyświetla wyniki
            Console.WriteLine("{0} {1} {2} {3}", car.Make, car.Model, car.Year, car.Color);
            Console.WriteLine("{0:C}", car.DetermineMarketValue());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year >= 1990)
            {
                carValue = 10000;
            }
            else
            {
                carValue = 2000;
            }

            return carValue;
        }
    }
}
