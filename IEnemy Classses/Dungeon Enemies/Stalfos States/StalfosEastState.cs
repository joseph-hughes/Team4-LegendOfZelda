using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Stalfos_States
{
    class StalfosEastState : IState
    {
        private IEnemy enemy;
        const int SPEED = 2;

        public StalfosEastState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Direction = Vector.Orientation.East;
        }

        public void North()
        {
            enemy.State = new StalfosNorthState(enemy);
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            enemy.State = new StalfosSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new StalfosWestState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X + enemy.Velocity.Magnitude, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
