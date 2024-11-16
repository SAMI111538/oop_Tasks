using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pacmanLibrary;
using pacmanLibrary.GameGL;

namespace pacmanLibrary
{
    class GameCell
    {
        int row;
        int col;
        GameObject currentGameObject;
        GameGrid grid;
        PictureBox pictureBox;
        const int width = 20;
        const int height = 20;

        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }

        public GameCell(int row, int col, GameGrid grid)
        {
            this.Row = row;
            this.Col = col;
            PictureBox = new PictureBox();
            PictureBox.Left = col * width;
            PictureBox.Top = row * height;
            PictureBox.Size = new Size(width, height);
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.BackColor = Color.Transparent;
            this.grid = grid;
        }

        public void setGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            PictureBox.Image = gameObject.Image;
        }
        public GameCell nextCell(GameDirection direction)
        {
            if(direction == GameDirection.LEFT)
            {
                if (this.col > 0)
                {
                    GameCell nCell = grid.getCell(Row, Col - 1);
                    if(nCell.currentGameObject.GameObjectType != GameObjectType.WALLS)
                    {
                        return nCell;
                    }
                }
                
            }
            if(direction == GameDirection.RIGHT)
            {
                if (this.col < grid.Cols - 1)
                {
                    GameCell nCell = grid.getCell(Row, Col + 1);
                    if(nCell.currentGameObject.GameObjectType != GameObjectType.WALLS)
                    {
                        return nCell;
                    }
                }
                
            }
            if(direction == GameDirection.UP)
            {
                if (row > 0)
                {
                    GameCell nCell = grid.getCell(Row-1, Col);
                    if(nCell.currentGameObject.GameObjectType != GameObjectType.WALLS)
                    {
                        return nCell;
                    }
                }
            }
            if(direction == GameDirection.DOWN)
            {
                if (row < grid.Rows - 1)
                {
                    GameCell nCell = grid.getCell(Row + 1, Col);
                    if(nCell.currentGameObject.GameObjectType != GameObjectType.WALLS)
                    {
                        return nCell;
                    }
                }
            }

            return null;
            

        }
    }
}
