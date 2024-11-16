using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;
using System.Drawing;
namespace PacMan.GameUL
{
    public class GameGhostHorizontal : GameGhost
    {
        private GameDirection direction;

        public GameGhostHorizontal(Image img, GameCell start) : base(img)
        {
            this.direction = GameDirection.Right;
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (nextCell == currentCell && direction == GameDirection.Right)
            {

                direction = GameDirection.Left;
            }
            else if (nextCell == currentCell && direction == GameDirection.Left)
            {
                direction = GameDirection.Right;
            }
            if (nextCell != currentCell)
            {
                nextCell.setGameObject(this);
                this.CurrentCell = nextCell;
                currentCell.setGameObject(Game.getBlankGameObject());

            }


            return currentCell.nextCell(direction);
        }
    }
}

