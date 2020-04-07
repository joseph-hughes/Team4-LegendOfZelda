using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    public class DodongoController : IController
    {
        private IEnemy enemy;
        private static int MIN_DIRECTION_COUNTS = 30, MAX_DIRECTION_COUNTS = 60;
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
                switch (RandomIntGenerator.Instance.Next(0, 3))
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
                directionCount = RandomIntGenerator.Instance.Next(MIN_DIRECTION_COUNTS, MAX_DIRECTION_COUNTS);
            }
        }
    }
}
