using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarApp.Core
{
    class Car
    {
        public string Name { get; private set; }
        public Car(string name)
        {
            Name = name;
        }
    }
}
