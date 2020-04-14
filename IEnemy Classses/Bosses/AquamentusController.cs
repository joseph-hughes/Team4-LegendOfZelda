using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class AquamentusController : IController
    {
        private IEnemy enemy;
        private const int MAX_Directon_COUNTS = 60, MIN_ATTACK_COUNTS = 100, MAX_ATTACK_COUNTS = 180;
        private UtilityClass utilities = new UtilityClass();
        private int DirectonCount, attackCount;

        public AquamentusController(IEnemy enemy)
        {
            this.enemy = enemy;
            DirectonCount = MAX_Directon_COUNTS;
            attackCount = RandomIntGenerator.Instance.Next(MIN_ATTACK_COUNTS, MAX_ATTACK_COUNTS);
        }
        public void Update()
        {
            DirectonCount--;
            if (DirectonCount <= 0)
            {
                if (enemy.Velocity.Directon == Vector.Orientation.East)
                {
                    enemy.West();
                }
                else
                {
                    enemy.East();
                }

                DirectonCount = MAX_Directon_COUNTS;
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
