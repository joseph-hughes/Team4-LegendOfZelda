using Team4_LegendOfZelda.Random_Number_Generator;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class KeeseController : IController
    {
        private IEnemy enemy;
        private int flyingCount, waitingCount, directionCount;

        public KeeseController(IEnemy enemy)
        {
            this.enemy = enemy;
            flyingCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.KeeseController_MIN_FLYING_COUNTS(), UtilityClass.Instance.KeeseController_MAX_FLYING_COUNTS());
            waitingCount = 0;
            directionCount = 0;
        }

        public void Update()
        {
            if (flyingCount <= 0)
            {
                if (enemy.Velocity.Magnitude > 0)
                {
                    enemy.Idle();
                }
                
                if (waitingCount <= 0)
                {
                    flyingCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.KeeseController_MIN_FLYING_COUNTS(), UtilityClass.Instance.KeeseController_MAX_FLYING_COUNTS());
                    waitingCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.KeeseController_MIN_WAITING_COUNT(), UtilityClass.Instance.KeeseController_MAX_WAITING_COUNT());
                }
                else
                {
                    waitingCount--;
                }
            }
            else
            {
                if (directionCount <= 0)
                {
                    switch (RandomIntGenerator.Instance.Next(0, 3))
                    {
                        case 0:
                            if (enemy.Velocity.Direction != Vector.Orientation.South)
                            {
                                enemy.North();
                            }
                            break;
                        case 1:
                            if (enemy.Velocity.Direction != Vector.Orientation.West)
                            {
                                enemy.East();
                            }
                            break;
                        case 2:
                            if (enemy.Velocity.Direction != Vector.Orientation.North)
                            {
                                enemy.South();
                            }
                            break;
                        case 3:
                            if (enemy.Velocity.Direction != Vector.Orientation.East)
                            {
                                enemy.West();
                            }
                            break;
                        default:
                            // Do nothing, this is not supposed to happen
                            break;
                    }
                    directionCount = RandomIntGenerator.Instance.Next(UtilityClass.Instance.KeeseController_MIN_DIRECTION_COUNT(), UtilityClass.Instance.KeeseController_MAX_DIRECTION_COUNT());
                }
                else
                {
                    directionCount--;
                }
                
                flyingCount--;
            }
        }
    }
}
