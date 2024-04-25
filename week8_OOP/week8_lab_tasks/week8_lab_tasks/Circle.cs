using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8_lab_tasks
{
    class Circle
    {
        protected double radius;
        protected string colour;
        protected double Area; 


        public Circle()
        {

        }

        public Circle(double r)
        {
            this.radius = r;
        }
        public Circle(double radius,string colour)
        {
            this.radius = radius;
            this.colour = colour;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }
        public void setcolour(string colour)
        {
            this.colour = colour;
        }
        public string getColour()
        {
            return colour;
        }

        public double getArea()
        {
            return Area;
        }

        public void setArea(double Area)
        {

        }
    }
}
