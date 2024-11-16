using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace GUIpacman.GameGl
{
    class ZigZagGhost : Ghost
    {
        GameDirection direction = GameDirection.Up;
        public ZigZagGhost(Image img, GameCell startCell, GameCell previousItem) : base(img, startCell, previousItem)
        {

        }

        public GameDirection Direction { get => direction; set => direction = value; }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(this.direction);

            GameCell newCell = new GameCell(nextCell.X, nextCell.Y, nextCell.Grid);
            newCell.SetGameObject(nextCell.CurrentGameObject);
            if (nextCell == currentCell && GameDirection.Up == Direction)
            {
                Direction = GameDirection.Down;
                return CurrentCell;
            }
            if (nextCell == currentCell && GameDirection.Down == Direction)
            {
                Direction = GameDirection.Up;
                return CurrentCell;
            }
            movement(Direction);
            movement(GameDirection.Left);
            movement(Direction);
            movement(GameDirection.Right);
            return newCell;
        }
        public void movement(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if(nextCell != currentCell)
            {
                currentCell.SetGameObject(PreviousItem.CurrentGameObject);
                PreviousItem.SetGameObject(nextCell.CurrentGameObject);
                nextCell.SetGameObject(this);
                this.CurrentCell = nextCell;
            }
        }
    }
}
