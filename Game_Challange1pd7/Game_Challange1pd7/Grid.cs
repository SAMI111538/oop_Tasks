using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game_Challange1pd7
{
    class Grid
    {
        public Cell[,] maze;
        public int row;
        public int column;
        public string path;

        public Grid()
        {

        }
        public Grid(string path, int rowSize, int coloumnSize)
        {
            this.row = rowSize;
            this.column = coloumnSize;
            this.path = path;
            this.maze = new Cell[rowSize, coloumnSize];
            string line = null;
            int y = 0;
            StreamReader myfile = new StreamReader(this.path);
            while ((line = myfile.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; x++)
                {
                    Cell temp = new Cell(line[x], x, y);
                    maze[y, x] = temp;
                }
                y++;
            }

            myfile.Close();
        }

        public void draw_Maze()
        {
            for (int y = 0; y < 19; y++)
            {
                for (int x = 0; x < 60; x++)
                {
                    Console.Write(maze[y, x].get_Value());
                }
                Console.WriteLine("");
            }
        }
        //public int t
        public Cell get_LeftCell(Cell c)
        {
            return c;
        }
        public Cell get_RightCell(Cell c)
        {
            return c;
        }
        public Cell get_UpCell(Cell c)
        {
            return c;
        }
        public Cell get_DownCell(Cell c)
        {
            return c;
        }
        //public Cell find_Pacman()
        //{

        //}
        //public Cell find_Ghost(char ghost_Character)
        //{
        //    return c;
        //}
        public bool isStopping()
        {
            return false;
        }

    }
}
