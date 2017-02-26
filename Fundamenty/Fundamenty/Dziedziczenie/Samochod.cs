using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty.Dziedziczenie
{              
    class Samochod : Pojazd   // : Pojazd - umożliwa dziedziczenie z nadklasy Pojazd

    {
        // dodatkowe pole dodane w podklasie Samochód
        private string _jakiePaliwo;

        // konstruktor nadpisujący te z nadklasy
        public Samochod(string marka, string model, int ileKol, int cena, string jakiePaliwo)
            : base (marka, model, ileKol, cena) // deklarujemy jakie pola mają zostać zainicjalowane z nadklasy
        {
            JakiePaliwo = jakiePaliwo;
        }

        // propercja (właściwość) pola
        public string JakiePaliwo
        {
            get
            {
                return _jakiePaliwo;
            }

            set
            {
                _jakiePaliwo = value;
            }
        }

        public override void Jedz() // override oznacza, że dziedziczymy metodę z nadklasy
        {
            Console.WriteLine("Samochód spala 8 litrów na 100 km/h.");
        }
    }
}
