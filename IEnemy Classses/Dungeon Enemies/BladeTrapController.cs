using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class BladeTrapController : IController
    {
        private IEnemy enemy;
        private static int MIN_DIRECTION_COUNTS = 60, MAX_DIRECTION_COUNTS = 180;
        private int directionCount;
        private Random rand;

        public BladeTrapController(IEnemy enemy)
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
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                directionCount = rand.Next(MIN_DIRECTION_COUNTS, MAX_DIRECTION_COUNTS + 1);
            }
        }
    }
}
