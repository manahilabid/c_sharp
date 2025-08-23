using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_10
{
    internal class Birds
    {
        public void Bird()
        {
            Console.WriteLine("the BIRDS");
        }
    }
    class sparrow : Birds
    {
        public void Bird()
        {
            Console.WriteLine("the SPARROW is a bird");
        }
    }
}
