using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week8_LabTask3.Animal_DL;

namespace week8_LabTask3
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat c1 = new Cat("Malik");
            Cat c2 = new Cat("Malika");

            Dog d1 = new Dog("Shery");
            Dog d2 = new Dog("Bar");


            DL.animal.Add(c1);
            DL.animal.Add(c2);
            DL.animal.Add(d1);
            DL.animal.Add(d2);

            foreach(Animal a in DL.animal)
            {
                Console.WriteLine(a.toString());
                a.Greets();
            }
            Console.ReadKey();
        }
    }
}
