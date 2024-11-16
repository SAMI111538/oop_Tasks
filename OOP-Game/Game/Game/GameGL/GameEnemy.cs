using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    abstract class GameEnemy : GameObject
    {

        public GameEnemy(Image ghostImage)
            : base(GameObjectType.ENEMY, ghostImage)
        {
        }

        public abstract GameCell nextCell();

        public abstract void move(GameCell gameCell);

        public abstract void generateBullet();

        public abstract void moveBullets();
    }
}
