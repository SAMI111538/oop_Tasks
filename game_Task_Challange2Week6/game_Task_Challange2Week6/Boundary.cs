using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_Task_Challange2Week6
{
    class Boundary
    {
        public Point top_left;
        public Point top_right;
        public Point bottom_left;
        public Point bottom_right;

        public Boundary()
        {

        }

        public Boundary(Point top_left, Point top_right, Point bottom_left, Point bottom_right)
        {
            this.top_left = new Point(0, 0);
            this.top_right = new Point(0, 90);
            this.bottom_left = new Point(90, 0);
            this.bottom_right = new Point(90, 90);
        }

    }
}
