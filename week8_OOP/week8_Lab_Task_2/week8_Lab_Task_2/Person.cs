using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8_Lab_Task_2
{
    class Person
    {
        protected string name;
        protected string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void setAdress(string address)
        {
            this.address = address;
        }

        public string GetAddress()
        {
            return address;
        }

        public virtual string toString()
        {
            return "Person"+"name = "+name+"address = "+address;
        }
    }
}
