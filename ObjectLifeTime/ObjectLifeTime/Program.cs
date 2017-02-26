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

            Car myOtherCar;
            myOtherCar = car;

            Car myThirdCar = new Car("Nissan", "GTR", 2010, "Red");
             
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Konstruktor - ustanawia wartość, która będzie domyślnie ustawiona po utworzeniu nowej instancji
        // parametr this jest opcjonalny. sugeruje, że wartość się tyczy to tej klasy
        // Kostruktor umożliwia zaciągnięcie danych o obiekcie z bazy danych lub innego pliku
        public Car()
        {
            this.Make = "Nissan";
        }

        // Override - pozwala na bezpośrednie zdefinownanie propercji przy tworzeniu nowej instancji klasy
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }


    }
}
