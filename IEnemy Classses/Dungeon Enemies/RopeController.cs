using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class RopeController : IController
    {
        private IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();

        private int directionCount;

        public RopeController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = utilities.MAX_DIRECTION_COUNTS6;
        }

        public void Update()
        {
            directionCount--;
            if (directionCount <= 0)
            {
                switch (RandomIntGenerator.Instance.Next(0, 3))
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
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                directionCount = utilities.MAX_DIRECTION_COUNTS6;
            }
        }
    }
}
