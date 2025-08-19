using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_08
{
    internal class std
    {
        public int Id;
        public string name;
        public string batch;

        public std(int id , string name , string batch = "not found")
        {
            this.Id = id;
            this.name = name;
            this.batch = batch;
        }
        public void data()
        {
            Console.WriteLine($"Id:{Id} Name:{name} Batch:{batch}");
        } 

    }
}
