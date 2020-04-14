using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.ZolDarkGreen_States
{
    class ZolDarkGreenSouthState : IState
    {
        private IEnemy enemy;
        private const int SPEED = 2;

        public ZolDarkGreenSouthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Direction = Vector.Orientation.South;
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            enemy.State = new ZolDarkGreenIdleState(enemy);
        }

        public void BeDamaged()
        {
            // Nothing
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y + SPEED, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
