using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    internal class GameCollision
    {
        public static bool isEnemyCollideWithPlayer(GameEnemy ghost)
        {
            bool flag = false;
            if (ghost.CurrentCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                flag = true;
            }
            return flag;
        }

        public static bool isPlayerBulletCollideWithEnemy(GameCell potentialCell)
        {
            bool flag = false;
            if (potentialCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                flag = true;
            }
            return flag;
        }

        public static bool isPlayerBulletCollideWithHorizontalEnemy(GameCell potentialCell)
        {
            bool flag = false;
            if (potentialCell.CurrentGameObject.GameObjectType == GameObjectType.HENEMY)
            {
                flag = true;
            }
            return flag;
        }
    }
}
