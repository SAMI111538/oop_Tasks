using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GUIpacman.GameGl
{
    abstract class Ghost : GameObject
    {
		private GameCell previousItem;
		public Ghost(Image img, GameCell startCell, GameCell previousItem) : base(GameObjectType.ENEMY, img)
		{
			this.previousItem = previousItem;
			this.CurrentCell = startCell;
		}
		public GameCell PreviousItem { get => previousItem; set => previousItem = value; }

        public abstract GameCell move();
	}
}
