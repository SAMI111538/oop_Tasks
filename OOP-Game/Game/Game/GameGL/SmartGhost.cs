using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    internal class SmartGhost : GameEnemy
    {
        private GamePlayer pacman;
        private GameDirection direction = GameDirection.Down;
        List<Bullet> bullets;
        public SmartGhost(Image ghostImage, GameCell startCell, GamePlayer pacman)
            : base(ghostImage)
        {
            base.CurrentCell = startCell;
            this.pacman = pacman;
            bullets = new List<Bullet>();
        }

        public override void generateBullet()
        {
            Bullet bullet = new Bullet(ImageGiver.getSmartEnemyBulletImage(), this.CurrentCell.nextCell(GameDirection.Left));
            bullets.Add(bullet);
        }

        public override void moveBullets()
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Left))
                {
                    GameCell currentCell = this.CurrentCell;
                    bullets[i].CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else if (bullets[i].nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    GameThings.decreasePlayerHealth(1);
                    GameCell currentCell = this.CurrentCell;
                    bullets[i].CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
                    bullets.RemoveAt(i);

                }
                else
                {
                    bullets[i].move(bullets[i].nextCell(GameDirection.Left));
                }
            }
        }
        public override void move(GameCell gameCell)
        {
            if (base.CurrentCell != null)
            {
                base.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
            }

            base.CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {

            double[] distance = new double[4] { 1000000, 1000000, 1000000, 1000000 };
            GameCell cell = CurrentCell.nextCell(direction);
            GamePlayer smart = pacman;
            if (cell != null)
            {
                distance[0] = calculateDistance(cell.X, cell.Y - 1);
                distance[1] = calculateDistance(cell.X, cell.Y + 1);
                distance[2] = calculateDistance(cell.X + 1, cell.Y);
                distance[3] = calculateDistance(cell.X - 1, cell.Y - 1);

                if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
                {
                    direction = GameDirection.Left;
                }
                else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
                {
                    direction = GameDirection.Right;
                }
                else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
                {
                    direction = GameDirection.Down;
                }
                else
                {
                    direction = GameDirection.Up;
                }
            }
            return cell;

        }

        double calculateDistance(int x, int Y)
        {
            return Math.Sqrt(Math.Pow((pacman.CurrentCell.X - x), 2) + Math.Pow((pacman.CurrentCell.Y - Y), 2));
        }
    }
}
