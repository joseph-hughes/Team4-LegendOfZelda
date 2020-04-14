using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    public class DodongoController : IController
    {
        private IEnemy enemy;
        private const int MIN_Directon_COUNTS = 30, MAX_Directon_COUNTS = 60;
        private UtilityClass utilities = new UtilityClass();
        private int DirectonCount;

        public DodongoController(IEnemy enemy)
        {
            this.enemy = enemy;
            DirectonCount = utilities.MAX_Directon_COUNTS;
        }
        public void Update()
        {
            DirectonCount--;
            if (DirectonCount <= 0)
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
                DirectonCount = RandomIntGenerator.Instance.Next(utilities.MIN_Directon_COUNTS, utilities.MAX_Directon_COUNTS);
            }
        }
    }
}
