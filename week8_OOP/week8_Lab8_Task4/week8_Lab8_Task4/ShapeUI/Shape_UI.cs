using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week8_Lab8_Task4.BL;

namespace week8_Lab8_Task4.ShapeUI
{
    class Shape_UI
    {
        public static Circle Take_Circle_Input()
        {
            Console.WriteLine("Enter Radius : ");
            double radius = double.Parse(Console.ReadLine());

            Circle c = new Circle(radius);
            return c;
        }

        public static Rectangle Take_rectangle_Input()
        {
            Console.WriteLine("Enter Width : ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height : ");
            double height = double.Parse(Console.ReadLine());

            Rectangle rec = new Rectangle(width,height);
            return rec;
        }

        public static Square Take_Square_Input()
        {
            Console.WriteLine("Enter Side : ");
            double side = double.Parse(Console.ReadLine());

            Square sq = new Square(side);
            return sq;
        }
    }
}
