using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //// zmienne zwykłe, nie będące wskaźnikami(referencjami)
            //int x = 10;
            //int y;

            //y = x;
            //x = 5;

            //Console.WriteLine("Zmienna x = " + x);
            //Console.WriteLine("Zmienna y = " + y);

            // zmienne wskaźnikowe (referencje)
            
            Car FirstCar = new Car();
            FirstCar.Color = "black";

            Car SecondCar = new Car();
            SecondCar.Color = "red";

            Console.WriteLine("Kolor pierwszego samochodu: " + FirstCar.Color);
            Console.WriteLine("Kolor drugiego samochodu: " + SecondCar.Color);

            FirstCar = SecondCar;
            Console.WriteLine("Kolor pierwszego samochodu: " + FirstCar.Color);

            FirstCar.Color = "white";
            Console.WriteLine("Kolor pierwszego samochodu: " + FirstCar.Color);
            Console.WriteLine("Kolor drugiego samochodu: " + SecondCar.Color);

            Console.ReadKey(); //konsola zamyka sie dopiero po wciśnięciu dowolnego klawisza
        }
    }
}
