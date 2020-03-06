using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class RopeController : IController
    {
        private IEnemy enemy;
        private static int MAX_DIRECTION_COUNTS = 240;
        private int directionCount;

        public RopeController(IEnemy enemy)
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
                directionCount = MAX_DIRECTION_COUNTS;
            }
        }
    }
}
