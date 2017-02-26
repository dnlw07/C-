using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.VIN = "A1";
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.VIN = "A2";
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.TItle = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            // ArrayLists old style collection, currently not used 
            // problem with the collection is that its loosely typed
            // if in colleciton are different class object its impossible to print for example only objects car.make
            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(car1);
            //myArrayList.Add(car2);
            //myArrayList.Add(b1);

            //foreach (Car car in myArrayList)
            //{
            //    Console.WriteLine(car.Make);
            //}

            // List<T>
            // w nawiasie <> podaje się konkretny rodzaj instancji jakie będą przechowydwane w kolekcji
            // ustawiając listę jako List<Car> niemożliwe jest wstawienie tam instancji książka
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);


            // Dictionary <TKey, Tvalue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A2"].Make);

            // tworzenie nowej tablicy
            string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            // tworzenie nowej instancji obiektu
            // nie ma potrzeby tworzenia konstruktora
            Car car3 = new Car() { Make = "BMW", Model = "750li", VIN = "A3" };
            Car car4 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "A4" };

            // inicjalizacja kolekcji
            List<Car> myList2 = new List<Car>()
            {
                new Car { Make = "BMW", Model = "750li", VIN = "A3" },
                new Car { Make = "Toyota", Model = "4Runner", VIN = "A4" }
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string TItle { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
