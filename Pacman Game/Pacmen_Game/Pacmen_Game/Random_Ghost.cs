using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacmen_Game
{
    class Random_Ghost : Ghost
    {
        public Random_Ghost(char displayCharcter, GameCell startCell) : base(displayCharcter, startCell)
        {
            this.direction = GameDirection.Left;
        }
        public override GameCell move()
        {
            GameCell Cell = CurrentCell.nextCell(direction);
            int number = Random();
            if(number == 1)
            {
                direction = GameDirection.Down;
            }
            if(number == 2)
            {
                direction = GameDirection.Up;
            }
            if(number == 3)
            {
                direction = GameDirection.Left;
            }
            if(number == 4)
            {
                direction = GameDirection.Right;
            }
            return Cell;

        }
        public int Random()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }

    }
}