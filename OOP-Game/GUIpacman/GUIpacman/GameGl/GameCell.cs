using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIpacman.GameGl
{
    class GameCell
    {
        int rows;
        int cols;
        GameObject currentGameObject;
        GameGrid grid;
        const int width = 20;
        const int height = 20;
        public PictureBox pictureBox;
        public GameCell(int rows, int cols, GameGrid grid)
        {
            this.rows = rows;
            this.cols = cols;
            this.grid = grid;
            pictureBox = new PictureBox();
            pictureBox.Left = cols * width;
            pictureBox.Top = rows * height;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
        }
        public void SetGameObject(GameObject gameobject)
        {
            currentGameObject = gameobject;
            pictureBox.Image = gameobject.DisplayImage;
        }

        public GameCell nextCell(GameDirection direction)
        {
            if (direction == GameDirection.Left)
            {
                if (this.cols > 0)
                {
                    GameCell ncell = grid.getCell(rows, cols - 1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Right)
            {
                if (this.cols < grid.Cols - 1)
                {
                    GameCell ncell = grid.getCell(this.rows, this.cols + 1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Up)
            {
                if (this.rows > 0)
                {
                    GameCell ncell = grid.getCell(this.rows - 1, this.cols);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Down)
            {
                if (this.rows < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.rows + 1, this.cols);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            return this; // if can not return next cell return its own reference
        }
        public int X { get => rows; set => rows = value; }
        public int Y { get => cols; set => cols = value; }
        public GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }
        internal GameGrid Grid { get => grid; set => grid = value; }
    }
}
