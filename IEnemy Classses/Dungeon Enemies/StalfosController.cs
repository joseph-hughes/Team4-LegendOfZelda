using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class StalfosController : IController
    {
        private IEnemy enemy;
        private static int MAX_DIRECTION_COUNTS = 30;
        private int directionCount;

        public StalfosController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = MAX_DIRECTION_COUNTS;
        }

        public void Update()
        {
            directionCount--;
            if (directionCount <= 0)
            {
                switch (RandomIntGenerator.Instance.Next(0, 4))
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
                        enemy.Idle();
                        break;
                    default:
                        // Do nothing
                        break;
                }
                directionCount = MAX_DIRECTION_COUNTS;
            }
        }
    }
}
