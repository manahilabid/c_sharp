using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace class_08
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("construction in C# c-sharp");
            int id = 1;
            string name = "manahil";
            string city = "karachi";
            Console.WriteLine($"id:{id} name:{name} city:{city}");

        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj1 = new Program();

            std std1 = new std(2 ,"Alen" , "5S");
            std1.data();

            std std2 = new std(3, "Sybil", "9D");
            std2.data();

            std std3 = new std(3, "lucky", "$F");
            std3.data();

            Console.WriteLine("\"\nAccess Modifiers\"");
            Console.ReadKey();
        }
        
    }
}
