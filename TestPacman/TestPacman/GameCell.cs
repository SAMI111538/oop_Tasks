using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPacman
{
    class GameCell
    {
        private int x;
        private int y;
        public GameGrid gameGrid;
        private GameObject currentGameObject;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        internal GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }

        public GameCell(int X, int Y, GameGrid gameGrid)
        {
            this.X = X;
            this.Y = Y;
            this.gameGrid = gameGrid;
        }

        public GameCell nextCell(GameDirection direction)
        {
            if(direction == GameDirection.Left)
            {
                if(this.Y > 0)
                {
                    GameCell nCell = gameGrid.getCell(X, Y - 1);
                    if (nCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nCell;
                    }
                }
            }
            if(direction == GameDirection.Right)
            {
                if(this.Y < gameGrid.Cols - 1)
                {
                    GameCell nCell = gameGrid.getCell(X, Y + 1);
                    if (nCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nCell;
                    }
                }
            }
            if (direction == GameDirection.Up)
            {
                if (this.X > 0)
                {
                    GameCell nCell = gameGrid.getCell(X - 1, Y);
                    if (nCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nCell;
                    }
                }
            }
            if (direction == GameDirection.Down)
            {
                if (this.X < gameGrid.Rows - 1)
                {
                    GameCell nCell = gameGrid.getCell(X +1, Y);
                    if (nCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nCell;
                    }
                }
            }
            return null;
        }

    }
}
