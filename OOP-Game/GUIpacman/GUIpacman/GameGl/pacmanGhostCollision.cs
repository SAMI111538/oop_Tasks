using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIpacman.GameGl
{
    class pacmanGhostCollision : Collision
    {
        public pacmanGhostCollision(GameObjectType firstObject, GameObjectType secondObject) : base(firstObject, secondObject)
        {

        }
        public override void Action()
        {
            Form1.lives--;
        }
    }
}
