using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIpacman.GameGl
{
    public class PacmanPalleteCollision : Collision
    {
        public PacmanPalleteCollision(GameObjectType firstObject, GameObjectType secondObject) : base(firstObject, secondObject)
        {

        }
        public override void Action()
        {
            Form1.totalScore++;
        }
    }
}
