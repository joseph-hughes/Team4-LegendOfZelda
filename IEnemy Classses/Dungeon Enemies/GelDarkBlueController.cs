using Microsoft.Xna.Framework;
using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class GelDarkBlueController : IController
    {
        private IEnemy enemy;
        private static int MIN_DIRECTION_COUNTS = 60, MAX_DIRECTION_COUNTS = 180;
        private int directionCount;
        private Random rand;

        public GelDarkBlueController(IEnemy enemy)
        {
            this.enemy = enemy;
            rand = new Random();
            directionCount = MAX_DIRECTION_COUNTS;
        }

        public void Update()
        {
            directionCount--;
            if (directionCount <= 0)
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        enemy.Position = new Vector2(enemy.Position.X, ((int)enemy.Position.Y - 10) % 600);
                        break;
                    case 1:
                        enemy.Position = new Vector2(((int)enemy.Position.X + 10) % 800, enemy.Position.Y);
                        break;
                    case 2:
                        enemy.Position = new Vector2(enemy.Position.X, ((int)enemy.Position.Y + 10) % 600);
                        break;
                    case 3:
                        enemy.Position = new Vector2(((int)enemy.Position.X - 10) % 800, enemy.Position.Y);
                        break;
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                directionCount = rand.Next(MIN_DIRECTION_COUNTS, MAX_DIRECTION_COUNTS + 1);
            }
        }
    }
}
