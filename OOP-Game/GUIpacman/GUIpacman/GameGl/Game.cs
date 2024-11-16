using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIpacman.GameGl
{
    class Game
    {
        public static GameObject getBlankgameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.simplebox1);
            return blankGameObject;
        }
        public static Image getGameObject(char displayCharacter)
        {
            Image img = GUIpacman.Properties.Resources.simplebox1;
            if (displayCharacter == '%')
            {
                img = GUIpacman.Properties.Resources.icons8_walls_32;
            }
            if (displayCharacter == '.')
            {
                img = GUIpacman.Properties.Resources.pallet;
            }
            if (displayCharacter == '#' || displayCharacter == '|')
            {
                img = GUIpacman.Properties.Resources.WoodenBox;
            }
            if (displayCharacter == 'p' || displayCharacter == 'P')
            {
                img = GUIpacman.Properties.Resources._649852e53b7e4edf15ea1c2f23a61f29_w200__1___1_;
            }
            return img;
        }
    }
}
