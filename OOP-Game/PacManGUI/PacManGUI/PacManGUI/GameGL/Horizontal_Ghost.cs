using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;

namespace PacManGUI.GameGL
{
    public class Horizontal_Ghost : Ghost
    {
        public Horizontal_Ghost(Image img, GameCell start) : base(img, start)
        {
            this.gameDirection = GameDirection.Right;
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(gameDirection);
            if (nextCell == currentCell && gameDirection == GameDirection.Right)
            {

                gameDirection = GameDirection.Left;
            }
            else if (nextCell == currentCell && gameDirection == GameDirection.Left)
            {
                gameDirection = GameDirection.Right;
            }
            if (nextCell != currentCell)
            {
                nextCell.setGameObject(this);
                this.CurrentCell = nextCell;
                currentCell.setGameObject(Game.getBlankGameObject());

            }


            return currentCell.nextCell(gameDirection);
        }
    }
}

