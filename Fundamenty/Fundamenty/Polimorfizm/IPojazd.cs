using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty.Polimorfizm
{
    public interface IPojazd // interfejs to zbiór metod (domyślnie publicznych), które nie mogą zostać zimplementowane
                             // litera I przed słowem pojazd oznacza, że jest to interfejs (konwencja)
                             // interfejsy nie mogą zawierać pól oraz konstruktorów, ale nie mogą zawierać właściwości
    {
        string Marka { get; set; }
        string Model { get; set; }
        string IleKol { get; set; }
        string Cena { get; set; }
    }
}
