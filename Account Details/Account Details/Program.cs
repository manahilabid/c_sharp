using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Account Details---------------");
            Account acc1 = new Account("manahil" , 3000);
            acc1.widthdraw(1000);
            Console.ReadKey();
        }
    }
}
