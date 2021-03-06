﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year  == 2010
                       select car;
             

            // sortowanie samochodów wg roku
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */


            // LINQ method
            // w nawiasach jest lambda expression
            // zwróć instancję p taką, że model intancji p jest "BMW" a rok jest "2010"
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            // sortowanie wg lambda
            //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");


            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            */

            // lambda w konsoli
            // Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));

            // pomniejsza cenę każdego auto o 3000;
            // myCars.ForEach(p => p.StickerPrice -= 3000);

            // for every single item in collection show VIN and StickerPrice
            // myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            // Zwraca czy czy istnieje samochód o modelu 750li
            //Console.WriteLine(myCars.Exists(p => p.Model == "750li"));

            // zwraca łączną cenę samochodów
            // Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            // zwraca typ obiektu
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());

            

            Console.ReadKey();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
