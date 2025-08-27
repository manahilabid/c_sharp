using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_11
{
    internal class Wild_Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("------------The Sound of the Wild Animals------------");
        } 
        
    }
    class Lion : Wild_Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The Lion hiss and snarl");
        }
    }

    class Elephant : Wild_Animal
    {
        public override void Sound() 
        {
            Console.WriteLine("The Elephant squeaks, and snorts");
        }
    }
}
