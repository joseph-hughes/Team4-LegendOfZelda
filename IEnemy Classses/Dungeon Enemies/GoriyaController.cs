using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class GoriyaController : IController
    {
        private IEnemy enemy;
        private int directionCount;

        public GoriyaController(IEnemy enemy)
        {
            this.enemy = enemy;
            directionCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.GoriyaController_MIN_DIRECTION_COUNTS(), UtilityClass.Instance.GoriyaController_MAX_DIRECTION_COUNTS());
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
                        enemy.Attack();
                        break;
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                directionCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.GoriyaController_MIN_DIRECTION_COUNTS(), UtilityClass.Instance.GoriyaController_MAX_DIRECTION_COUNTS());
            }
        }
    }
}
