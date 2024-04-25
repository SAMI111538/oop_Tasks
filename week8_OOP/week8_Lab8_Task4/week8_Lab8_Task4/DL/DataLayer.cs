using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week8_Lab8_Task4.BL;

namespace week8_Lab8_Task4.DL
{
    class DataLayer
    {
        public static List<Shape> shape = new List<Shape>();

        public static void addIntoList(Shape s)
        {
            shape.Add(s);
        }
    }
}
