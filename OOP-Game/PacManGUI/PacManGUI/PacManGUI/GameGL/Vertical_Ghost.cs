using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManGUI.GameGL;
using PacMan.GameGL;

namespace PacManGUI.GameGL
{
    class Vertical_Ghost : Ghost
    {
        public Vertical_Ghost(char displayCharacter, GameCell start) : base(displayCharacter, start)
        {
            gameDirection = GameDirection.Up;
        }
        public override GameCell move()
        {
            GameCell Cell = CurrentCell.nextCell(gameDirection);
            if (Cell == null )
            {
                if(gameDirection == GameDirection.Up)
                {
                    gameDirection = GameDirection.Down;
                }
                else if(gameDirection == GameDirection.Down)
                {
                    gameDirection = GameDirection.Up;
                }
            }
            return null;
        }
    }
}
