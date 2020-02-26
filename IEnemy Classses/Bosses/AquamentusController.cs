using Microsoft.Xna.Framework;
using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class AquamentusController : IController
    {
        private IEnemy enemy;
        private int count, maxCount;
        private Random rand;
        private enum Direction { EAST, WEST };
        private Direction direction;

        public AquamentusController(IEnemy enemy)
        {
            this.enemy = enemy;

            count = 0;
            maxCount = 60;
            direction = Direction.EAST;
            rand = new Random();
        }
        public void Update()
        {
            switch (direction)
            {
                case Direction.EAST:
                    enemy.Position = new Vector2(((int)enemy.Position.X + 2) % 768, enemy.Position.Y);
                    break;
                case Direction.WEST:
                    enemy.Position = new Vector2(((int)enemy.Position.X - 2) % 768, enemy.Position.Y);
                    break;
                default:
                    // Do nothing, this is not supposed to happen
                    break;
            }

            count++;
            if (count > maxCount)
            {
                switch (rand.Next(0, 3))
                {
                    case 0:
                        direction = Direction.EAST;
                        break;
                    case 1:
                        direction = Direction.WEST;
                        break;
                    case 2:
                        enemy.State.Attack();
                        break;
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                count = 0;
            }
        }
    }
}
