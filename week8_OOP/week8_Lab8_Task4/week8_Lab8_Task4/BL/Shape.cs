using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week8_Lab8_Task4.ShapeUI;

namespace week8_Lab8_Task4.BL
{
    class Shape
    {
        public Shape()
        {
        }

        public virtual double getArea()
        {
            return 0.0;
        }

        public virtual string ToString()
        {
            return null;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height) : base()
        {
            this.width = width;
            this.height = height;
        }


        public override double getArea()
        {
            return ( height *width);
        }

        public override string ToString()
        {
            return "Rectangle";
        }
    }

    class Circle : Shape
    {
        private double radius;


        public Circle(double radius) : base()
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            return (2 * 3.14 *radius * radius);
        }

        public override string ToString()
        {
            return "Circle";
        }
    }

    class Square : Shape
    {
        private double side;

        public Square(double side) : base()
        {
            this.side = side;
        }

        public override double getArea()
        {
            return (side * side);
        }

        public override string ToString()
        {
            return "Square";
        }
    }

}
