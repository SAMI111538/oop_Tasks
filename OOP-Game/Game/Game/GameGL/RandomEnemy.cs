using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    internal class RandomEnemy : GameEnemy
    {
        private GameDirection direction = GameDirection.Down;
        List<Bullet> bullets;
        public RandomEnemy(Image ghostImage, GameCell startCell)
            : base(ghostImage)
        {
            base.CurrentCell = startCell;
            bullets = new List<Bullet>();
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
            int value = generateRandomNumber();
            if (value == 0)
            {
                direction = GameDirection.Right;
            }
            else if (value == 1)
            {
                direction = GameDirection.Left;
            }
            else if (value == 2)
            {
                direction = GameDirection.Up;
            }
            else if (value == 3)
            {
                direction = GameDirection.Down;
            }
            GameCell gameCell = base.CurrentCell;
            GameCell gameCell2 = base.CurrentCell.nextCell(direction);
            return gameCell2;
        }

        public override void generateBullet()
        {
            Bullet bullet = new Bullet(ImageGiver.getRandomEnemyBulletImage(), this.CurrentCell.nextCell(GameDirection.Left));
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

        public int generateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(4);
        }
    }
}
