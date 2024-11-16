using EZInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace GUIpacman.GameGl
{
    class GameObject
    {
        char displayCharacter;
        Image displayImage;
        GameObjectType gameObjectType;
        GameCell currentCell;
        public GameObject(GameObjectType type, char displayCharacter)
        {
            this.displayCharacter = displayCharacter;
            this.gameObjectType = type;

        }
        public GameObject(GameObjectType type, Image displayImage)
        {
            this.displayImage = displayImage;
            this.gameObjectType = type;

        }
        public GameObject(GameCell c, GameObjectType type, Image DisplayImage)
        {
            this.gameObjectType = type;
            this.displayImage = DisplayImage;
            this.currentCell = c;
        }

        public static GameObjectType getGameObjectType(char displayCharacter)
        {

            if (displayCharacter == '|' || displayCharacter == '%' || displayCharacter == '#')
            {
                return GameObjectType.WALL;
            }

            if (displayCharacter == '.')
            {
                return GameObjectType.REWARD;
            }
            if(displayCharacter == 'p' || displayCharacter == 'P')
            {
                return GameObjectType.Main;
            }
            return GameObjectType.NONE;
        }
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.CurrentGameObject = this;
            }
        }
        public Image DisplayImage { get => displayImage; set => displayImage = value; }
    }
}
