using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GUIpacman.GameGl
{
    class SGhost : Ghost
    {
		private GameDirection direction;
		public SGhost(Image img, GameCell startCell, GameCell previousItem) : base(img, startCell, previousItem)
		{

		}

		public GameDirection Direction { get => direction; set => direction = value; }

		public override GameCell move()
		{
			GameCell pacManCell = this.CurrentCell.Grid.getPacmanCell();
			if (pacManCell != null)
            {
				if (this.CurrentCell.X - pacManCell.X > 0)
				{
					Direction = GameDirection.Up;
					movement(GameDirection.Up);
				}
				if (this.CurrentCell.X - pacManCell.X < 0)
				{
					Direction = GameDirection.Down;
					movement(GameDirection.Down);
				}
				if (this.CurrentCell.Y - pacManCell.Y > 0)
				{
					Direction = GameDirection.Left;
					movement(GameDirection.Left);
				}
				if (this.CurrentCell.Y - pacManCell.Y < 0)
				{
					Direction = GameDirection.Right;
					movement(GameDirection.Right);
				}
			}
			return CurrentCell;
		}
		public void movement(GameDirection direction)
        {
			GameCell currentCell = this.CurrentCell;
			GameCell nextcell = currentCell.nextCell(direction);
			if (currentCell != nextcell)
			{
				if (nextcell.CurrentGameObject.GameObjectType == GameObjectType.Main)
					Form1.lives--;
				currentCell.SetGameObject(PreviousItem.CurrentGameObject);
				PreviousItem.SetGameObject(nextcell.CurrentGameObject);
				nextcell.SetGameObject(this);
				this.CurrentCell = nextcell;
			}
		}
	}
}
