using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GUIpacman.GameGl
{
    class RGhost : Ghost
    {
		public RGhost(Image img, GameCell startCell, GameCell previousItem) : base(img, startCell, previousItem)
		{

		}


		public override GameCell move()
		{
			
			GameCell currentCell = this.CurrentCell;
			GameCell nextcell = currentCell.nextCell(returnDirection());

			GameCell newCell = new GameCell(nextcell.X, nextcell.Y, nextcell.Grid);
			newCell.SetGameObject(nextcell.CurrentGameObject);
			if (currentCell != nextcell)
			{
				currentCell.SetGameObject(PreviousItem.CurrentGameObject);
				PreviousItem.SetGameObject(nextcell.CurrentGameObject);
				nextcell.SetGameObject(this);
				this.CurrentCell = nextcell;
			}
			return newCell;
		}

		private GameDirection returnDirection()
        {
			GameDirection Direction = GameDirection.Up;
			Random random = new Random();
			int num = random.Next(0, 4);
			if (num == 0)
			{
				Direction = GameDirection.Right;
			}
			else if (num == 1)
			{
				Direction = GameDirection.Left;
			}
			else if (num == 2)
			{
				Direction = GameDirection.Down;
			}
			else if (num == 3)
			{
				Direction = GameDirection.Up;
			}
			return Direction;
		}
	}
}
