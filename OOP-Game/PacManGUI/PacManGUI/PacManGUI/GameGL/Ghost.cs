using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;

namespace PacManGUI.GameGL
{
    public class Ghost : GameObject
    {
        public GameDirection gameDirection;
        public Ghost(Image image, GameCell startCell) : base(GameObjectType.ENEMY , image)
        {
            CurrentCell = startCell;
        }
        GameDirection direction;

        public override GameCell move()
        {
            return null;
        }
    }
}