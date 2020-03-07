using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    public class DodongoController : IController
    {
        private IEnemy enemy;
        private static int MIN_DIRECTION_COUNTS = 100, MAX_DIRECTION_COUNTS = 300;
        private int directionCount;

        public DodongoController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = MAX_DIRECTION_COUNTS;
        }
        public void Update()
        {
            directionCount--;
            if (directionCount <= 0)
            {
                switch (RandomIntGenerator.Instance.Next(0, 5))
                {
                    case 0:
                        enemy.Idle();
                        enemy.North();
                        break;
                    case 1:
                        enemy.Idle();
                        enemy.East();
                        break;
                    case 2:
                        enemy.Idle();
                        enemy.South();
                        break;
                    case 3:
                        enemy.Idle();
                        enemy.West();
                        break;
                    case 4:
                        enemy.BeDamaged();
                        break;
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                directionCount = RandomIntGenerator.Instance.Next(MIN_DIRECTION_COUNTS, MAX_DIRECTION_COUNTS);
            }
        }
    }
}
