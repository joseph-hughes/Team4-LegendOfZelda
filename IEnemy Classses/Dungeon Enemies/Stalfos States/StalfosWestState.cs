using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Stalfos_States
{
    class StalfosWestState : IState
    {
        private IEnemy enemy;
        const int SPEED = 2;
        private UtilityClass utilities = new UtilityClass();

        public StalfosWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Directon = Vector.Orientation.West;
        }

        public void North()
        {
            enemy.State = new StalfosNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new StalfosEastState(enemy);
        }

        public void South()
        {
            enemy.State = new StalfosSouthState(enemy);
        }

        public void West()
        {
            // Do nothing
        }
        public void Idle()
        {
            enemy.State = new StalfosIdleState(enemy);
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void Attack()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X - enemy.Velocity.Magnitude, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
