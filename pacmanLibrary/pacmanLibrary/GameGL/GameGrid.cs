using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacmanLibrary
{
    class GameGrid
    {
        GameCell[,] GameCells;
        int rows;
        int cols;

        public GameGrid(string filename , int row, int col)
        {
            Rows = row;
            Cols = col;
            GameCells = new GameCell[Rows, Cols];
        }

        public int Rows { get => rows; set => rows = value; }
        public int Cols { get => cols; set => cols = value; }

        public GameCell getCell(int x, int y)
        {
            return GameCells[x, y];
        }
    }
}
