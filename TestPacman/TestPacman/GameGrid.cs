using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestPacman
{
    class GameGrid
    {
        GameCell[,] GameCells;
        public int Rows;
        public int Cols;

        public GameGrid(string filename, int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            GameCells = new GameCell[24, 71];
            loadGrid(filename);
        }

        private void loadGrid(string filename)
        {
            StreamReader fp = new StreamReader(filename);
            string record = "";

            for (int i = 0; i < Rows; i++)
            {
                record = fp.ReadLine();
                for (int j = 0; j < Cols; j++)
                {
                    GameCell cell = new GameCell(i, j, this);
                    char displayCharacter = record[j];
                    GameObjectType type = GameObject.GetGameObjectType(displayCharacter);
                    GameObject gameObject = new GameObject(type, displayCharacter);
                    cell.CurrentGameObject = gameObject;
                    GameCells[i, j] = cell;
                }
            }
            fp.Close();
        }

        public GameCell getCell(int x, int y)
        {
            return GameCells[x, y];
        }
    }
}
