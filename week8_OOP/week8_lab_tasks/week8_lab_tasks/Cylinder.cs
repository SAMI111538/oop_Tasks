using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8_lab_tasks
{
    class Cylinder:Circle
    {
        private double height;
        private double Volume;

        public Cylinder():base()
        {

        }
        public Cylinder(double radius): base(radius)
        {
            this.radius = radius;
        }
        public Cylinder(double radius,string colour):base(radius,colour)
        {
            this.radius = radius;
            this.colour = colour;
        }

        public Cylinder(double radius, string colour, double height):base(radius, colour)
        {
            this.radius = radius;
            this.colour = colour;
            this.height = height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }

        public double getVolume()
        {
            return Volume;
        }
    }
}
