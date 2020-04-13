using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class BladeTrapController : IController
    {
        private IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();

        private int directionCount;

        public BladeTrapController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = utilities.MAX_DIRECTION_COUNTS3;
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
                directionCount = RandomIntGenerator.Instance.Next(utilities.MIN_DIRECTION_COUNTS2, utilities.MAX_DIRECTION_COUNTS3);
            }
        }
    }
}
