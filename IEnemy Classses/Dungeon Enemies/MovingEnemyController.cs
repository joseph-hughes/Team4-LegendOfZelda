using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class MovingEnemyController : IController
    {
        private IEnemy enemy;
        private int MAX_DIRECTION_COUNTS;
        private int directionCount;
        private Random rand;

        public MovingEnemyController(IEnemy enemy, int max_direction_counts)
        {
            this.enemy = enemy;
            this.MAX_DIRECTION_COUNTS = max_direction_counts;
            rand = new Random();
            directionCount = this.MAX_DIRECTION_COUNTS;
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
                directionCount = this.MAX_DIRECTION_COUNTS;
            }
        }
    }
}
