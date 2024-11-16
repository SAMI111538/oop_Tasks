using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GUIpacman.GameGl
{
    class GamePacManPlayer : GameObject
    {
		public GamePacManPlayer(Image img, GameCell startCell) : base(GameObjectType.Main, img)
		{
			this.CurrentCell = startCell;
		}

		public GameCell movePacman(GameDirection direction)
		{
			GameCell currentCell = this.CurrentCell; //8,10
			GameCell nextCell = currentCell.nextCell(direction); //8,11

			GameCell newCell = new GameCell(nextCell.X, nextCell.Y, nextCell.Grid);
			newCell.SetGameObject(nextCell.CurrentGameObject);
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                Form1.totalScore++;
            }
            nextCell.SetGameObject(this);
			this.CurrentCell = nextCell;
			if (currentCell != nextCell)
            {
				currentCell.SetGameObject(Game.getBlankgameObject());
			}
			return newCell;
		}
	}
}
