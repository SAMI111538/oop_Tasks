using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.GameGL;

namespace Game.GameGL
{
    internal class GameObject
    {
        private char displayCharacter;

        private GameObjectType gameObjectType;

        private GameCell currentCell;

        private Image image;

        public char DisplayCharacter
        {
            get
            {
                return displayCharacter;
            }
            set
            {
                displayCharacter = value;
            }
        }

        public GameObjectType GameObjectType
        {
            get
            {
                return gameObjectType;
            }
            set
            {
                gameObjectType = value;
            }
        }

        public GameCell CurrentCell
        {
            get
            {
                return currentCell;
            }
            set
            {
                currentCell = value;
                currentCell.setGameObject(this);
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        public GameObject(GameObjectType type, Image image)
        {
            gameObjectType = type;
            Image = image;
        }

        public GameObject(GameObjectType type, char displayCharacter)
        {
            gameObjectType = type;
            this.displayCharacter = displayCharacter;
        }

        public static GameObjectType getGameObjectType(char displayCharacter)
        {
            switch (displayCharacter)
            {
                case '#':
                case '%':
                case '|':
                    return GameObjectType.WALL;
                case '.':
                    return GameObjectType.REWARD;
                default:
                    return GameObjectType.NONE;
            }
        }
    }
}
