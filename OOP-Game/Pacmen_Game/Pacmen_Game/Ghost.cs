using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacmen_Game
{
    class Ghost : GameObject
    {
        public Ghost(char DisplayCharacter,GameCell start):base(GameObjectType.ENEMY, DisplayCharacter)
        {
            this.CurrentCell = start;
        }
        public GameDirection direction;

        public override GameCell move()
        {
            return null;
        }

    }
}
