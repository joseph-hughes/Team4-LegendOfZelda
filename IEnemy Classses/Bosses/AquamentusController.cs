using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class AquamentusController : IController
    {
        private IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
        private int directionCount, attackCount;
        private enum Direction { EAST, WEST };
        private Direction direction;

        public AquamentusController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = utilities.MAX_DIRECTION_COUNTS;
            attackCount = RandomIntGenerator.Instance.Next(utilities.MIN_ATTACK_COUNTS, utilities.MAX_ATTACK_COUNTS);
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
                directionCount = utilities.MAX_DIRECTION_COUNTS;
            }

            attackCount--;
            if (attackCount <= 0)
            {
                enemy.Attack();
                attackCount = RandomIntGenerator.Instance.Next(utilities.MIN_ATTACK_COUNTS, utilities.MAX_ATTACK_COUNTS);
            }
        }
    }
}
