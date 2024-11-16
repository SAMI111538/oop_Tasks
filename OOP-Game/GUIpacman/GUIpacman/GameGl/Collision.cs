using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIpacman.GameGl
{
    public abstract class Collision
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
    }
}
