using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    internal class Bullet : GameObject
    {
        public Bullet(Image image, GameCell startCell)
            : base(GameObjectType.BULLET, image)
        {
            base.CurrentCell = startCell;
        }

        public void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }

        public GameCell nextCell(GameDirection direction)
        {
            return this.CurrentCell.nextCell(direction);
        }
    }
}
