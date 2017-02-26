using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty.Polimorfizm
{
    public abstract class Zwierze
    {
        private string _gatunek;
        private string _rodzaj;

        public string Gatunek
        {
            get
            {
                return _gatunek;
            }

            set
            {
                _gatunek = value;
            }
        }

        public string Rodzaj
        {
            get
            {
                return _rodzaj;
            }

            set
            {
                _rodzaj = value;
            }
        }

        public Zwierze(string gatunek, string rodzaj)
        {
            Gatunek = gatunek;
            Rodzaj = rodzaj;
        }

        public abstract void PodajSwojGatunek();

        public void PodajSwójRodzaj()
        {
            Console.WriteLine("Jestem: " + Rodzaj);
        }

    }
}
