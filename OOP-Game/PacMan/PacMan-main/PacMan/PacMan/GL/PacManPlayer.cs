using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.GL
{
    class PacManPlayer
    {
        public PacManPlayer(int pacmanX, int pacmanY) 
        {
            this.pacmanX = pacmanX;
            this.pacmanY = pacmanY;
        
        }
        public int pacmanX;
        public int pacmanY;

    }
}
