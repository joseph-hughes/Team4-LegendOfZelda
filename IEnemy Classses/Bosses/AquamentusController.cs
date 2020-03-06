using Microsoft.Xna.Framework;
using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class AquamentusController : IController
    {
        private IEnemy enemy;
        private static int MAX_DIRECTION_COUNTS = 60, MIN_ATTACK_COUNTS = 100, MAX_ATTACK_COUNTS = 180;
        private int directionCount, attackCount;
        private Random rand;
        private enum Direction { EAST, WEST };
        private Direction direction;

        public AquamentusController(IEnemy enemy)
        {
            this.enemy = enemy;
            rand = new Random();
            directionCount = MAX_DIRECTION_COUNTS;
            attackCount = rand.Next(MIN_ATTACK_COUNTS, MAX_ATTACK_COUNTS + 1);
            direction = Direction.EAST;
        }
        public void Update()
        {
            switch (direction)
            {
                case Direction.EAST:
                    enemy.DestinationRectangle = new Rectangle(((int)enemy.DestinationRectangle.X + 2) % 768, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                    break;
                case Direction.WEST:
                    if (enemy.DestinationRectangle.X >= 2)
                    {
                        enemy.DestinationRectangle = new Rectangle((enemy.DestinationRectangle.X - 2) % 768, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                    }
                    else
                    {
                        enemy.DestinationRectangle = new Rectangle(768 - (int)enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                    }
                    
                    
                    break;
                default:
                    // Do nothing, this is not supposed to happen
                    break;
            }

            directionCount--;
            if (directionCount <= 0)
            {
                direction = 1 - direction;
                directionCount = MAX_DIRECTION_COUNTS;
            }

            attackCount--;
            if (attackCount <= 0)
            {
                enemy.Attack();
                attackCount = rand.Next(MIN_ATTACK_COUNTS, MAX_ATTACK_COUNTS + 1);
            }
        }
    }
}
