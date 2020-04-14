using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;
namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class GoriyaController : IController
    {
        private IEnemy enemy;
        private const int MIN_Directon_COUNTS = 30, MAX_Directon_COUNTS = 120;
        private UtilityClass utilities = new UtilityClass();
        private int DirectonCount;

        public GoriyaController(IEnemy enemy)
        {
            this.enemy = enemy;
            DirectonCount = RandomIntGenerator.Instance.Next(MIN_Directon_COUNTS, MAX_Directon_COUNTS);
        }

        public void Update()
        {
            DirectonCount--;
            if (DirectonCount <= 0)
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
                        enemy.Attack();
                        break;
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                DirectonCount = RandomIntGenerator.Instance.Next(MIN_Directon_COUNTS, MAX_Directon_COUNTS);
            }
        }
    }
}
