using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    internal class HorizontalEnemy : GameEnemy
    {
        GameDirection direction = GameDirection.Left;
        List<Bullet> bullets;

        public HorizontalEnemy(Image ghostImage, GameCell startCell) : base(ghostImage)
        {
            this.CurrentCell = startCell;
            this.bullets = new List<Bullet>();
        }

        public override void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {

            GameCell nextCell = this.CurrentCell;

            GameCell potentialNextCell = this.CurrentCell.nextCell(direction);

            if (potentialNextCell == nextCell)
            {
                if (direction == GameDirection.Left)
                {
                    direction = GameDirection.Right;
                }
                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
                }
            }
            else
            {
                nextCell = potentialNextCell;
            }
            return nextCell;

        }

        public override void generateBullet()
        {
            Bullet bullet = new Bullet(ImageGiver.getHorizontalEnemyBulletImage(), this.CurrentCell.nextCell(GameDirection.Left));
            bullets.Add(bullet);
        }

        public override void moveBullets()
        {
            /*foreach(var bullet in bullets)
            {
                if(bullet.CurrentCell == bullet.nextCell())
                {
                    GameCell currentCell = this.CurrentCell;
                    this.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
                    bullets.Remove(bullet);
                }
                else
                {
                    bullet.move(bullet.nextCell());
                }
            }*/
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
    }
}
