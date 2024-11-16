using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Properties;

namespace Game.GameGL
{
    internal class ImageGiver
    {
        public static GameObject getBlankGameObject()
        {
            return new GameObject(GameObjectType.NONE, Resources.simplebox);
        }

        public static Image getPlayerImage()
        {
            return Resources.mario;
        }

        public static Image getVerticalEnemyImage()
        {
            return Resources.vertical_png;
        }

        public static Image getHorizontalEnemyImage()
        {
            return Resources.horizontal_ghost;
        }

        public static Image getRandomEnemyImage()
        {
            return Resources.random;
        }
        public static Image getSmartEnemyImage()
        {
            return Resources.smart;
        }

        public static Image getPlayerBulletImage()
        {
            return Resources.playerBullet;
        }

        public static Image getHorizontalEnemyBulletImage()
        {
            return Resources.enemyBullet1;
        }

        public static Image getRandomEnemyBulletImage()
        {
            return Resources.randomEnemyBullet;
        }
        public static Image getVerticalEnemyBulletImage()
        {
            return Resources.verticalEnemyBullet;
        }
        public static Image getSmartEnemyBulletImage()
        {
            return Resources.verticalEnemyBullet;
        }
        public static GameObject GiveHeart()
        {
            return new GameObject(GameObjectType.HEART, Resources.coins);
        }


        public static Image getGameObjectImage(char displayCharacter)
        {
            Image result = Resources.simplebox;

            if (displayCharacter == '#')
            {
                result = Resources.Wall;
            }

            if (displayCharacter == '*')
            {
                result = Resources.coins;
            }

            return result;
        }
    }
}
