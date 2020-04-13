using Team4_LegendOfZelda.Random_Number_Generator;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class GelAndZolController : IController
    {
        private IEnemy enemy;
        private const int MIN_WAIT_COUNTS = 5, MAX_WAIT_COUNTS = 20, MAX_DISPLACEMENT_STD = 16;
        private int waitCount, displacement, maxDisplacement;

        public GelAndZolController(IEnemy enemy)
        {
            this.enemy = enemy;
            waitCount = RandomIntGenerator.Instance.Next(MIN_WAIT_COUNTS, MAX_WAIT_COUNTS);
            maxDisplacement = (int)(MAX_DISPLACEMENT_STD * this.enemy.Scale);
            displacement = 0;
        }

        public void Update()
        {
            if (displacement <= 0)
            {
                if (waitCount > 0)
                {
                    if (enemy.Velocity.Magnitude > 0)
                    {
                        enemy.Idle();
                    }
                    waitCount--;
                }
                else
                {
                    switch (RandomIntGenerator.Instance.Next(0, 3))
                    {
                        case 0:
                            enemy.North();
                            displacement = maxDisplacement;
                            waitCount = RandomIntGenerator.Instance.Next(MIN_WAIT_COUNTS, MAX_WAIT_COUNTS);
                            break;
                        case 1:
                            enemy.East();
                            displacement = maxDisplacement;
                            waitCount = RandomIntGenerator.Instance.Next(MIN_WAIT_COUNTS, MAX_WAIT_COUNTS);
                            break;
                        case 2:
                            enemy.South();
                            displacement = maxDisplacement;
                            waitCount = RandomIntGenerator.Instance.Next(MIN_WAIT_COUNTS, MAX_WAIT_COUNTS);
                            break;
                        case 3:
                            enemy.West();
                            displacement = maxDisplacement;
                            waitCount = RandomIntGenerator.Instance.Next(MIN_WAIT_COUNTS, MAX_WAIT_COUNTS);
                            break;
                        default:
                            // Do nothing, this isn't supposed to happen
                            break;
                    }
                }
            }
            else
            {
                displacement -= enemy.Velocity.Magnitude;
            }
        }
    }
}
