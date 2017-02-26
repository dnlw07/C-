using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // kolekcja cars
            List <Car> cars = new List<Car>()
            {
                new Car { Brand = "BMW", Color = "Black", Year = 1990 },
                new Car { Brand = "BMW", Color = "Red", Year = 1992 },
                new Car { Brand = "Audi", Color = "Yellow", Year = 1996 },
                new Car { Brand = "Ford", Color = "Green", Year = 1990 }
            };


            // zapytanie LINQ (language integrated query) a la SQL - zapytanie do kolekcji cars (bazy danych)
            // kolekcja bmws (wynik zapytania z kolekcji cars)
            var bmws = from car in cars
                       where car.Brand == "BMW"
                       select car;

            Console.WriteLine("BMW Collection using LINQ: ");
            foreach (var bmw in bmws)
            {
                Console.WriteLine("Color = {0}, Year = {1}", bmw.Color, bmw.Year);
            }



            // zapytanie LAMBDA - inna froma zapytania do bazy danych (kolekcji cars)
            var selected = cars.Where(p => p.Year == 1990);

            Console.WriteLine("\n" + "My collection using Lambda:");
            foreach (var mySelected in selected)
            {
                Console.WriteLine("Color = {0}, Year = {1}", mySelected.Color, mySelected.Year);
            }

            Console.ReadKey();
        }
    }
}
