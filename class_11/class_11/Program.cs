using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wild_Animal wa1 = new Wild_Animal();
            wa1.Sound();

            Wild_Animal wa2 = new Lion();
            wa2.Sound();

            Wild_Animal wa3 = new Elephant();
            wa3.Sound();

            Console.ReadKey();
        }
    }
}
