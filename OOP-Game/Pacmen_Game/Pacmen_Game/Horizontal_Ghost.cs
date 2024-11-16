using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacmen_Game
{
    class Horizontal_ghost : Ghost 
    {
        public Horizontal_ghost(char displayCharcter, GameCell startCell) : base(displayCharcter, startCell)
        {
            this.direction = GameDirection.Right;
        }

        public override GameCell move()
        {
            GameCell Cell = CurrentCell.nextCell(direction);
            if (Cell == null)
            {
                if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
                }
                else
                {
                    direction = GameDirection.Right;
                }
            }
            return Cell;
        }
    }
}
