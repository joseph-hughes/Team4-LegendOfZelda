using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class AquamentusController : IController
    {
        private IEnemy enemy;
        private static int MAX_DIRECTION_COUNTS = 60, MIN_ATTACK_COUNTS = 100, MAX_ATTACK_COUNTS = 180;
        private int directionCount, attackCount;

        public AquamentusController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = MAX_DIRECTION_COUNTS;
            attackCount = RandomIntGenerator.Instance.Next(MIN_ATTACK_COUNTS, MAX_ATTACK_COUNTS);
        }
        public void Update()
        {
            directionCount--;
            if (directionCount <= 0)
            {
                if (enemy.Velocity.Direction == Vector.Orientation.East)
                {
                    enemy.West();
                }
                else
                {
                    enemy.East();
                }

                directionCount = MAX_DIRECTION_COUNTS;
            }

            attackCount--;
            if (attackCount <= 0)
            {
                enemy.Attack();
                attackCount = RandomIntGenerator.Instance.Next(MIN_ATTACK_COUNTS, MAX_ATTACK_COUNTS);
            }
        }
    }
}
