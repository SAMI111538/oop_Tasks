using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacmen_Game
{
    class Vertical_Ghost : Ghost
    {
        public Vertical_Ghost(char displayCharcter,GameCell startCell):base(displayCharcter,startCell)
        {
            this.direction = GameDirection.Down;
        }
        public override GameCell move()
        {
            GameCell Cell = CurrentCell.nextCell(direction);
            if(Cell == null)
            {
                if(direction == GameDirection.Up)
                {
                    direction = GameDirection.Down;
                }
                else if(direction == GameDirection.Down)
                {
                    direction = GameDirection.Up;
                }
            }
            return Cell;
        }
    }
}
