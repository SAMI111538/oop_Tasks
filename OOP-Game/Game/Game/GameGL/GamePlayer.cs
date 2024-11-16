using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.GameGL
{
    internal class GamePlayer : GameObject
    {
        public static List<Bullet> bullets;
        public GamePlayer(Image image, GameCell startCell)
            : base(GameObjectType.PLAYER, image)
        {
            base.CurrentCell = startCell;
            bullets = new List<Bullet>();
        }

        public void move(GameCell gameCell)
        {
            base.CurrentCell = gameCell;
        }

        public void moveBullets()
        {
            for(int i = 0;i < bullets.Count;i++)
            {
                if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Right))
                {
                    GameCell currentCell = this.CurrentCell;
                    bullets[i].CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
                    bullets.RemoveAt(i);
                }
                else if (GameCollision.isPlayerBulletCollideWithEnemy(bullets[i].nextCell(GameDirection.Right)))
                {
                    GameThings.addScore(1);
                    GameCell currentCell = this.CurrentCell;
                    bullets[i].CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
                    bullets.RemoveAt(i);

                }
                else
                {
                    bullets[i].move(bullets[i].nextCell(GameDirection.Right));
                }
            }
        }

        public void generateBullet()
        {
            Bullet bullet = new Bullet(ImageGiver.getPlayerBulletImage(),this.CurrentCell.nextCell(GameDirection.Right));
            bullets.Add(bullet);
        }
    }
}
