using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace class_10
{
    internal class Car1
    {
            public string name;
            public string color;
            public int model;   
            public void Title()
            {
             
                Console.WriteLine("it's the Parent Class");
            }
        
    }

    class BMW : Car1
    {
        public void details()
        {
            Console.WriteLine($"CarName :{name} CarColor :{color} CarModel :{model}");
        }
    }

    class Gwegan : Car1
    {
        public void details()
        {
            Console.WriteLine($"CarName :{name} CarColor :{color} CarModel :{model}");
        }
    }

}
