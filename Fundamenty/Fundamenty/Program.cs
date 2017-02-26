using Fundamenty.Polimorfizm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamenty
{
    class Program
    {
       static void Main(string[] args)
        {
            // przykład polimorfizmu Pojazd jest samochodem, ale może też być rowerem
            IPojazd pojazd = new Car("Marka1", "white");
        }
    }
}