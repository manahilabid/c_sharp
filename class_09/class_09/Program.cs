using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.derivedfun();

            obj.name = "Jeni";
            obj.color = "Brown";
            obj.sound = "Bark";
            obj.AnimalData();
            cat cat = new cat();
            cat.name = "Kitty";
            cat.color = "Blue";
            cat.sound = "Meow";
            cat.AnimalData();
            cat.catfun();
            Console.ReadKey();
        }
    }
}
