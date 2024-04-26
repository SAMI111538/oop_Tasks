using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Challange1pd7
{
    class Cell
    {
        public char Value;
        public int x;
        public int y;

        public Cell(char Value, int x, int y)
        {
            this.Value = Value;
            this.x = x;
            this.y = y;
        }

        public char get_Value()
        {
            return Value;
        }

        public void set_Value(char Value)
        {
            this.Value = Value;
        }

        public int get_X()
        {
            return x;
        }

        public int get_Y()
        {
            return y;
        }

        public void set_X(int x)
        {
            this.x = x;
        }
        public void set_Y(int y)
        {
            this.y = y;
        }

        public bool is_Pacman_Present()
        {
            return false;
        }
        public bool is_Ghost_Present(char ghost_Character)
        {
            return false;
        }
    }
}
