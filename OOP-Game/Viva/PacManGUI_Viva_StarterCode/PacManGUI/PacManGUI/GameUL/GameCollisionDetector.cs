using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;
namespace PacMan.GameUL
{
    class GameCollisionDetector
    {

        private GameObjectType firstObject;
        private GameObjectType secondObject;

        public Collision(GameObjectType firstObject, GameObjectType secondObject)
        {
            this.firstObject = firstObject;
            this.secondObject = secondObject;
        }

        public GameObjectType FirstObject { get => firstObject; set => firstObject = value; }
        public GameObjectType SecondObject { get => secondObject; set => secondObject = value; }

        public abstract void Action();

        public bool isGhostCollideWithPacMan(GameGhost ghost) {
            bool flag = false;
            //Write your Code Here

            if()
            return flag;
        }

        public bool isPacManCollideWithPallet(GameCell potentialCell) {
            bool flag = false;
            //Write your Code Here

            return flag;

        }
    }
}
