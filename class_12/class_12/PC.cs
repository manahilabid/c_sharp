using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_12
{
    abstract class PC
    {
        public abstract void name();
        public abstract void color();
        public void detail()
        {
            Console.WriteLine("Abstract class and method");
            Console.WriteLine("This is the Abstract class");
        }
    }
    class Dell : PC
    {
        public override void name()
        {
            Console.WriteLine("This Pc name is dell");
        }
        public override void color()
        {
            Console.WriteLine("The color is black");
        }
    }
    class HP : PC
    {
        public override void name()
        {
            Console.WriteLine("This PC name is HP");
        }
        public override void color()
        {
            Console.WriteLine("The color is white");

        }
    }
}
