using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPacman
{
    class GameObject
    {
        char displayCharacter;
        GameCell currentCell;
        GameObjectType gameObjectType;

        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        internal GameCell CurrentCell { get => currentCell; set => currentCell = value; }
        internal GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public GameObject(GameObjectType type,char DisplayCharacter)
        {
            this.displayCharacter = DisplayCharacter;
            this.gameObjectType = type;
        }
        public static GameObjectType GetGameObjectType(char displayCharacter)
        {
            if (displayCharacter == '|' || displayCharacter == '%' || displayCharacter == '#')
            {
                return TestPacman.GameObjectType.WALL;
            }
            else if (displayCharacter == '.')
            {
                return TestPacman.GameObjectType.REWARD;
            }
            return TestPacman.GameObjectType.NONE;
        }
    }
}
