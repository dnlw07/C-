using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty.Dziedziczenie
{
    class Pojazd
    {
        // pola prywatne
        private string _marka;
        private string _model;
        private int _ileKol;
        private int _cena;

        ///propercje (właściwości) pól - umożliwiają modyfikację pól z zewnątrz
        public string Marka
        {
            get     //co to jest get?
            {
                return _marka;
            }

            set     //co to jest set?
            {
                _marka = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public int IleKol
        {
            get
            {
                return _ileKol;
            }

            set
            {
                _ileKol = value;
            }
        }

        public int Cena
        {
            get
            {
                return _cena;
            }

            set
            {
                _cena = value;
            }
        }

        /// Występują trzy konstruktury o różnej ilości parametrów. 
        /// Poniższy przykład przedsdtawia przeciążenie konstruktorów.

        // konstruktor przyjmujący 2 parametry
        public Pojazd(string marka, string model)
        {
            Marka = _marka;
            Model = _model;
        }

        // konstruktor przyjmujący 4 parametry
        public Pojazd(string arka, string model, int ileKol, int cena)
        {
            Marka = _marka;
            Model = _model;
            IleKol = _ileKol;
            Cena = _cena;
        }

        // konstruktor przyjmujący 0 parametróws
        public Pojazd() { }

        // public virtual w nadklaskie umożliwia dziedzicenie w podklasach
        public virtual void Jedz()
        {
            Console.WriteLine("Pojazd jedzie...");
        }
    }
}
