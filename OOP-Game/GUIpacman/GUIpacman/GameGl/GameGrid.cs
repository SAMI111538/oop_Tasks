using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIpacman.GameGl
{
    class GameGrid
    {
        GameCell[,] cells;
        int rows;
        int cols;

        public GameGrid(String fileName, int rows, int cols)
        {
            //Numbers of rows and cols should load from the text file
            this.rows = rows;
            this.cols = cols;
            cells = new GameCell[rows, cols];
            this.loadGrid(fileName);
        }
       
        public int Rows { get => rows; set => rows = value; }
        public int Cols { get => cols; set => cols = value; }
        internal GameCell[,] Cells { get => cells; set => cells = value; }

        public GameCell getCell(int x, int y)
        {
            return cells[x, y];
        }

        void loadGrid(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string record;
            for (int row = 0; row < this.rows; row++)
            {
                record = fp.ReadLine();
                for (int col = 0; col < this.cols; col++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    Char displayCharacter = record[col];
                    GameObjectType type = GameObject.getGameObjectType(displayCharacter);
                    Image displyImage = Game.getGameObject(displayCharacter);
                    GameObject gameObject = new GameObject(type, displyImage);
                    cell.SetGameObject(gameObject);
                    cell.CurrentGameObject = gameObject;
                    cells[row, col] = cell;
                }
            }
            fp.Close();
        }
        public GameCell getPacmanCell()
        {
            for(int i= 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if(cells[i,j].CurrentGameObject.GameObjectType == GameObjectType.Main)
                    {
                        return cells[i, j];
                    }
                }
            }
            return null;
        }
    }
}
