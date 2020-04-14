using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class AquamentusController : IController
    {
        private IEnemy enemy;
        private int directionCount, attackCount;

        public AquamentusController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = UtilityClass.Instance.AquamentusController_MAX_DIRECTION_COUNTS();
            attackCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.AquamentusController_MIN_ATTACK_COUNTS(), UtilityClass.Instance.AquamentusController_MAX_ATTACK_COUNTS());
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

                directionCount = UtilityClass.Instance.AquamentusController_MAX_DIRECTION_COUNTS();
            }

            attackCount--;
            if (attackCount <= 0)
            {
                enemy.Attack();
                attackCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.AquamentusController_MIN_ATTACK_COUNTS(), UtilityClass.Instance.AquamentusController_MAX_ATTACK_COUNTS());
            }
        }
    }
}
