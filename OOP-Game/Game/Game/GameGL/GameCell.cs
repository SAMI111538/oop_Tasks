using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.GameGL
{
    internal class GameCell
    {
        private int row;

        private int col;

        private GameObject currentGameObject;

        private GameGrid grid;

        private PictureBox pictureBox;

        private const int width = 32;

        private const int height = 32;

        public int X
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public int Y
        {
            get
            {
                return col;
            }
            set
            {
                col = value;
            }
        }

        public GameObject CurrentGameObject => currentGameObject;

        public PictureBox PictureBox
        {
            get
            {
                return pictureBox;
            }
            set
            {
                pictureBox = value;
            }
        }

        public GameCell(int row, int col, GameGrid grid)
        {
            this.row = row;
            this.col = col;
            pictureBox = new PictureBox();
            pictureBox.Left = col * width;
            pictureBox.Top = row * height;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            this.grid = grid;
        }

        public void setGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.Image;
        }

        public GameCell nextCell(GameDirection direction)
        {
            if (direction == GameDirection.Left && col > 0)
            {
                GameCell cell = grid.getCell(row, col - 1);
                if (cell.CurrentGameObject.GameObjectType != 0)
                {
                    return cell;
                }
            }

            if (direction == GameDirection.Right && col < grid.Cols - 1)
            {
                GameCell cell2 = grid.getCell(row, col + 1);
                if (cell2.CurrentGameObject.GameObjectType != 0)
                {
                    return cell2;
                }
            }

            if (direction == GameDirection.Up && row > 0)
            {
                GameCell cell3 = grid.getCell(row - 1, col);
                if (cell3.CurrentGameObject.GameObjectType != 0)
                {
                    return cell3;
                }
            }

            if (direction == GameDirection.Down && row < grid.Rows - 1)
            {
                GameCell cell4 = grid.getCell(row + 1, col);
                if (cell4.CurrentGameObject.GameObjectType != 0)
                {
                    return cell4;
                }
            }

            return this;
        }
    }
}
