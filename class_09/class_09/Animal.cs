using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_09
{
    internal class Animal
    {
        public string name;
        public string color;
        public string sound;

        private void Data()
        {
            Console.WriteLine("this is the parent of the private method");
        }
    }
    class Dog : Animal
    {
        public void derivedfun()
        {
            Console.WriteLine("this is the child class");
        }
        public void AnimalData()
        {
            Console.WriteLine($"\nName:{name} Color:{color}Sound:{sound}");
        }
    }
    class cat : Animal
    {
        public void AnimalData()
        {
            Console.WriteLine($"Name:{name} Color:{color} Sound:{sound}");
        }
        public void catfun()
        {
            this.AnimalData();
        }
    }
}
