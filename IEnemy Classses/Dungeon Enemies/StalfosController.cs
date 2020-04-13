using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class StalfosController : IController
    {
        private IEnemy enemy;
        private const int MIN_DIRECTION_COUNTS = 5, MAX_DIRECTION_COUNTS = 30;
        private int directionCount;

        public StalfosController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = RandomIntGenerator.Instance.Next(MIN_DIRECTION_COUNTS, MAX_DIRECTION_COUNTS);
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
                        // Do nothing
                        break;
                }
                directionCount = RandomIntGenerator.Instance.Next(MIN_DIRECTION_COUNTS, MAX_DIRECTION_COUNTS);
            }
        }
    }
}
