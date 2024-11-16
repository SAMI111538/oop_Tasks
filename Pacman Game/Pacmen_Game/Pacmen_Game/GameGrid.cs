using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacmen_Game
{
    class GameGrid
    {
        public GameCell[,] GameCells;
        public int row;
        public int cols;

        public GameGrid()
        {
        }

        public GameGrid(string filename, int row, int cols)
        {
            this.row = row;
            this.cols = cols;
            GameCells = new GameCell[row, cols];

            loadGrid(filename);
        }
        private void loadGrid(string filename)
        {
           // string path = @"C:\Users\AL-FATAH LAPTOP\OneDrive\Desktop\maze_Pacman.txt";
            StreamReader fp = new StreamReader(filename);
            string record = " ";
            for (int i = 0; i < row; i++)
            {
                record = fp.ReadLine();
                for (int j = 0; j < cols; j++)
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
