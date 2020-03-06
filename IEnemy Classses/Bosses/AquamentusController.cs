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
                    enemy.Position = new Rectangle (((int)enemy.Position.X + 2) % 768, enemy.Position.Y, enemy.Position.Width, enemy.Position.Height);
                    break;
                case Direction.WEST:
                    if (enemy.Position.X >= 2)
                    {
                        enemy.Position = new Rectangle(((int)enemy.Position.X - 2) % 768, enemy.Position.Y, enemy.Position.Width, enemy.Position.Height);
                    }
                    else
                    {
                        enemy.Position = new Rectangle(768 - (int)enemy.Position.X, enemy.Position.Y, enemy.Position.Width, enemy.Position.Height);
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
