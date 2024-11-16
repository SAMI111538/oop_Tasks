using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacmen_Game
{
    class GameObject
    {
        char displayCharacter;
        GameCell currentCell;
        GameObjectType gameObjectType;

        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        internal GameCell CurrentCell { get => currentCell; set => currentCell = value; }
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }

        public GameObject(GameObjectType type, char DisplayCharacter)
        {
            this.GameObjectType = type;
            this.DisplayCharacter = DisplayCharacter;
        }
        public virtual GameCell move()
        {
            return null;
        }
        public static GameObjectType GetGameObjectType(char displayCharacter)
        {
            if(displayCharacter == '|' || displayCharacter == '%' || displayCharacter == '#')
            {
                return Pacmen_Game.GameObjectType.WALL;
            }
            else if(displayCharacter == '.')
            {
                return Pacmen_Game.GameObjectType.REWARD;
            }
            return Pacmen_Game.GameObjectType.NONE;
        }
    }
}

