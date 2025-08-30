using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------ARRAY in C#------------");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] stdName = { "Saleha", "Waseela", "Manahil" };
            Console.WriteLine(numbers[1]);
            Console.WriteLine(stdName[2]);

            foreach (string std in stdName)
            {
                Console.WriteLine(std);
            }

            int[] count = new int[10];
            count[0] = 11;
            count[1] = 12;
            count[2] = 13;
            count[3] = 14;
            count[4] = 15;
            count[5] = 16;
            count[6] = 17;
            count[7] = 18;
            count[9] = 19;
            foreach (int c in count)
            {
                Console.WriteLine(c);
            }
            object[] stdData = {1,"Alen",18,70.1,true};
            foreach (object s in stdData)
            {
                Console.Write($"{s} ");
            }

            var datalist = new List<dynamic>
            {
                new{name = "saleha" , age = 12 , batch = "5f"},
                new{name = "Sybil" , age = 12 , batch = "5f"},
                new{name = "Eden" , age = 12 , batch = "5f"},
                new{name = "Anna" , age = 12 , batch = "5f"},
                new{name = "Waseela" , age = 12 , batch = "5f"}
            };
            foreach (var data in datalist)
            {
                Console.WriteLine($"Name:{data.name},Age:{data.age},batch:{data.batch}");
            }
            Console.ReadKey();

        }
    }
}
