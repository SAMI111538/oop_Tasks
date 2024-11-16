using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GUIpacman.GameGl
{
    class VGhost : Ghost
    {
		private GameDirection direction = GameDirection.Up;
		public VGhost(Image img, GameCell startCell, GameCell previousItem) : base(img, startCell, previousItem)
		{

		}

		public GameDirection Direction { get => direction; set => direction = value; }

		public override GameCell move()
		{
			GameCell currentCell = this.CurrentCell;
			GameCell nextcell = currentCell.nextCell(this.direction);

			GameCell newCell = new GameCell(nextcell.X, nextcell.Y, nextcell.Grid);
			newCell.SetGameObject(nextcell.CurrentGameObject);

			if (nextcell == currentCell && this.Direction == GameDirection.Up)
			{
				Direction = GameDirection.Down;
				return CurrentCell;
			}
			if (nextcell == currentCell && this.Direction == GameDirection.Down)
			{
				Direction = GameDirection.Up;
				return CurrentCell;
			}
			
			if (currentCell != nextcell)
			{
				currentCell.SetGameObject(PreviousItem.CurrentGameObject);
				PreviousItem.SetGameObject(nextcell.CurrentGameObject);
				nextcell.SetGameObject(this);
				this.CurrentCell = nextcell;
			}
			return newCell;
		}
	}
}
