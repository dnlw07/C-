using Fundamenty.Polimorfizm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty
{
    class Car : IPojazd

    {
        // dodatkowe pole dodane w podklasie Samochód
        private string _brand;
        private string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Color { get; set; }

        public string myProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Marka
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Model
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string IleKol
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Cena
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Car(string brand, string color)
        {
            _brand = brand;
            Color = color;
        }

        public void DisplayBrand()
        {
            Console.WriteLine("Marka auta to:  (0)", _brand);
        }

        public void Jedz()
        {
            throw new NotImplementedException();
        }
    }
}