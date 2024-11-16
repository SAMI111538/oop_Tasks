using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.GL
{
    class Ghost
    {
       public int ghostX ;
        public int ghostY ;
        public string ghostDirection;
        public float speed; //value should be between 0 and 1.

        
        public Ghost(int ghostX, int ghostY, string ghostDirection, float speed) 
        {
            this.ghostX = ghostX;
            this.ghostY = ghostY;
            this.ghostDirection = ghostDirection;
            this.speed = speed;
        }
      

    }
}
