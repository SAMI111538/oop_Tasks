using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacmen_Game
{
    class GameCell
    {
        int x;
        int y;
        GameObject currentGameObject;
        GameGrid gameGrid;

        public GameCell(int x, int y, GameGrid gameGrid)
        {
            X = x;
            Y = y;
            this.gameGrid = gameGrid;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        internal GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }

        public GameCell nextCell(GameDirection direction)
        {
            if (direction == GameDirection.Left)
            {
                if (this.Y >= 0)
                {
                    GameCell nCell = gameGrid.getCell(X, Y - 1);
                    if (nCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nCell;
                    }
                }
            }
            if (direction == GameDirection.Right)
            {
                if (this.Y < gameGrid.cols - 1)
                {
                    GameCell nCell = gameGrid.getCell(this.X, this.Y + 1);
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
                    GameCell nCell = gameGrid.getCell(this.X - 1, this.Y);
                    if (nCell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nCell;
                    }
                }
            }

            if (direction == GameDirection.Down)
            {
                if (this.X < gameGrid.row - 1)
                {
                    GameCell nCell = gameGrid.getCell(this.X + 1, this.Y);
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
