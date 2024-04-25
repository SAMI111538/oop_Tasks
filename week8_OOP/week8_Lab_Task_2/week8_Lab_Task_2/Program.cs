using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8_Lab_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Sami", "Hafizabad", "BSCS", 1, 5000);
            Student s2 = new Student("Ali", "Pindi Bhattian", "BSCS", 1, 5000);

            Staff a = new Staff("Aslam", "HAFIZABAD", "Govt SCHOOL", 20000);
            Staff b = new Staff("BARR", "SIALKOT", "Govt SCHOOL", 15000);

            Console.WriteLine(s1.toString());
            Console.WriteLine(s2.toString());

            Console.WriteLine(a.toString());
            Console.WriteLine(b.toString());

            Console.ReadKey();
        }
    }
}
