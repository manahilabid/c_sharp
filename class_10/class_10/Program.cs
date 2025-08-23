using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW car = new BMW();
            car.name = "BMW";
            car.color = "brown";
            car.model = 2322;
            car.details();


            Gwegan car1 = new Gwegan();
            car.name = "G-wegon";
            car.color = "white";
            car.model = 2000;
            car.details();

            Birds bird = new Birds();
            bird.Bird();

            sparrow Sparrow = new sparrow();
            Sparrow.Bird();

            Console.ReadKey();
        }
    }
}
