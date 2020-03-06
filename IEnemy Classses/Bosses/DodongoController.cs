using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    public class DodongoController : IController
    {
        private IEnemy enemy;
        private static int MIN_DIRECTION_COUNTS = 100, MAX_DIRECTION_COUNTS = 300;
        private int directionCount;
        private Random rand;

        public DodongoController(IEnemy enemy)
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
                switch (rand.Next(0, 5))
                {
                    case 0:
                        enemy.North();
                        break;
                    case 1:
                        enemy.East();
                        break;
                    case 2:
                        enemy.South();
                        break;
                    case 3:
                        enemy.West();
                        break;
                    case 4:
                        enemy.BeDamaged();
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
