using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacmanLibrary
{
    class GameObject
    {
        GameCell currentCell;
        char displayCharacter;
        GameObjectType gameObjectType;
        Image image;
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        internal GameCell CurrentCell { get => currentCell; set => currentCell = value; }
        internal GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public Image Image { get => image; set => image = value; }

        public GameObject(GameObjectType type, char displayCharacter)
        {
            gameObjectType = type;
            this.displayCharacter = displayCharacter;
        }
        public GameObject(GameObjectType type, Image image)
        {
            gameObjectType = type;
            this.Image = image;
        }

        public static GameObjectType getGameObjectType(char displayCharacter)
        {

            if (displayCharacter == '|' || displayCharacter == '%' || displayCharacter == '#')
            {
                return GameObjectType.WALLS;
            }

            if (displayCharacter == '.')
            {
                return GameObjectType.REWARDS;
            }

            return GameObjectType.NONE;
        }

    }
}
