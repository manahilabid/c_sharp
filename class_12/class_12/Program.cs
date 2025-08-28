using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_12
{
    internal class Program
    {
        interface Student
        {
            void StudentName();
            void Subject();
        }
        class std1 : Student
        {
            public void StudentName()
            {
                Console.WriteLine("name:manahil \n class:matric");
            }
            public void Subject()
            {
                Console.WriteLine("science");
            }
        }
        static void Main(string[] args)
        {
          Dell dell = new Dell();
            dell.name();
            dell.color();

            PC hP = new HP();
            hP.name();
            hP.color();

            Student std1 = new std1();
            std1.StudentName();
            std1.Subject();

            Console.ReadKey();

        }
    }
}
