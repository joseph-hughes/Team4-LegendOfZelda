using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    public class BladeTrapController : IController
    {
        private IEnemy enemy;
        private const int ACTIVATION_DISTANCE_STD = 300;
        private int activationDistance;
        private UtilityClass utilities = new UtilityClass();

        public BladeTrapController(IEnemy enemy)
        {
            this.enemy = enemy;
            activationDistance = (int) (enemy.Scale * ACTIVATION_DISTANCE_STD);
        }

        public void Update()
        {
            Rectangle playerRectangle = enemy.Room.Player.DestinationRectangle;

            Rectangle enemyActivationAreaNorth = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y - activationDistance, enemy.DestinationRectangle.Width, activationDistance);
            Rectangle enemyActivationAreaEast = new Rectangle(enemy.DestinationRectangle.X + enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Y, activationDistance, enemy.DestinationRectangle.Height);
            Rectangle enemyActivationAreaSouth = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y + enemy.DestinationRectangle.Height, enemy.DestinationRectangle.Width, activationDistance);
            Rectangle enemyActivationAreaWest = new Rectangle(enemy.DestinationRectangle.X - activationDistance, enemy.DestinationRectangle.Y, activationDistance, enemy.DestinationRectangle.Height);

            if (!Rectangle.Intersect(playerRectangle, enemyActivationAreaNorth).IsEmpty)
            {
                enemy.North();
            }
            else if (!Rectangle.Intersect(playerRectangle, enemyActivationAreaEast).IsEmpty)
            {
                enemy.East();
            }
            else if (!Rectangle.Intersect(playerRectangle, enemyActivationAreaSouth).IsEmpty)
            {
                enemy.South();
            }
            else if (!Rectangle.Intersect(playerRectangle, enemyActivationAreaWest).IsEmpty)
            {
                enemy.West();
            }
        }
    }
}
