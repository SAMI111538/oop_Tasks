using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.GameUL
{
    public class GameGhostChaser : GameGhost
    {
        GameDirection direction;

        public GameDirection Direction { get => direction; set => direction = value; }

        public GameGhostChaser(Image ghostImage, GameCell startCell) : base(ghostImage)
        {
            this.Direction = GameDirection.Left;
        }
        public  GameCell move()
        {

            double[] distance = new double[4] { 1000000, 1000000, 1000000, 1000000 };
            GameCell cell = CurrentCell.nextCell(Direction);

            if (cell != null)
            {
                distance[0] = calculateDistance(cell.X, cell.Y - 1, cell.CurrentGameObject.CurrentCell.X,cell.CurrentGameObject.CurrentCell.Y);
                distance[1] = calculateDistance(cell.X, cell.Y + 1, cell.CurrentGameObject.CurrentCell.X, cell.CurrentGameObject.CurrentCell.Y);
                distance[2] = calculateDistance(cell.X + 1, cell.Y, cell.CurrentGameObject.CurrentCell.X, cell.CurrentGameObject.CurrentCell.Y);
                distance[3] = calculateDistance(cell.X - 1, cell.Y - 1, cell.CurrentGameObject.CurrentCell.X, cell.CurrentGameObject.CurrentCell.Y);



                if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
                {
                    Direction = GameDirection.Left;
                }
                else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
                {
                    Direction = GameDirection.Right;
                }
                else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
                {
                    Direction = GameDirection.Down;
                }
                else
                {
                    Direction = GameDirection.Up;
                }
            }
            return cell;

        }

        static double calculateDistance(int x, int Y, int pX, int pY)
        {
            return Math.Sqrt(Math.Pow((pX - x), 2) + Math.Pow((pY - Y), 2));
        }
    }

    

    

}

