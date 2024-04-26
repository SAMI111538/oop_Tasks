using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Challange1pd7
{
    class Ghost
    {
        public int x;
        public int y;
        public string Ghost_Direction;
        public char ghost_Character;
        public float speed;
        public char previous_Item;
        public float delta_Change;
        public Grid maze_Grid;

        public Ghost(int x, int y, string Ghost_Direction, char ghost_Character, float speed, char previous_Item, float delta_Change, Grid maze_Grid)
        {
            this.x = x;
            this.y = y;
            this.Ghost_Direction = Ghost_Direction;
            this.ghost_Character = ghost_Character;
            this.speed = speed;
            this.previous_Item = previous_Item;
            this.delta_Change = delta_Change;
            this.maze_Grid = maze_Grid;
        }

        public void set_Direction(string Ghost_Direction)
        {

        }
        public string get_Direction()
        {
            return Ghost_Direction;
        }

        public void Remove_ghost()
        {

        }

        public void draw_Ghost()
        {

        }

        public char get_Character()
        {
            return ' ';
        }

        public void Change_Delta()
        {

        }

        public float get_Delta()
        {
            return 0F;
        }

        public void set_Delta_Zero()
        {

        }

        public void Move()
        {

        }
        public void Move_Horizontal()
        {

        }
        public void Move_Vertical()
        {

        }

        public int Generate_Random()
        {
            return 0;
        }
        public void Move_Random()
        {

        }
        public void Move_Smart()
        {

        }

        public double Calculate_Distance(Cell Current, Cell pacman_Location)
        {
            return 0;
        }

    }
}
