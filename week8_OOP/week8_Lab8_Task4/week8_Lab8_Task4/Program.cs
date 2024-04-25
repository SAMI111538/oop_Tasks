using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week8_Lab8_Task4.ShapeUI;
using week8_Lab8_Task4.BL;
using week8_Lab8_Task4.DL;

namespace week8_Lab8_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = Shape_UI.Take_rectangle_Input();
            Square sq = Shape_UI.Take_Square_Input();
            Circle c = Shape_UI.Take_Circle_Input();
            Rectangle r1 = Shape_UI.Take_rectangle_Input();
            Circle c1 = Shape_UI.Take_Circle_Input();
            DataLayer.addIntoList(r);
            DataLayer.addIntoList(c);
            DataLayer.addIntoList(sq);
            DataLayer.addIntoList(r1);
            DataLayer.addIntoList(c1);
            foreach (Shape s in DataLayer.shape)
            {
                Console.WriteLine("The name of the shape is " + s.ToString() + " and the area is " +s.getArea());
            }
            Console.ReadKey();
        
        }
    }
}
