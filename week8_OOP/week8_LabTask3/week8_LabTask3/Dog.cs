using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8_LabTask3
{
    class Dog:Mamel
    {
        public Dog(string name) : base(name)
        {
            this.name = name;
        }

        public override string toString()
        {
            return "Dog : [" + base.toString() + "]";
        }

        public override void Greets()
        {
            Console.WriteLine("wooof");
        }
    }
}
