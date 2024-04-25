using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8_LabTask3
{
    class Mamel:Animal
    {
        public Mamel(string name):base(name)
        {
            this.name = name;
        }

        public override string toString()
        {
            return "Mamel : " +base.toString();
        }

        public override void Greets()
        {

        }
            

    }
}
