using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.Rope_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeNorthState : IState
    {
        private IEnemy enemy;
        private const int SPEED = 1;

        public RopeNorthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Direction = Vector.Orientation.North;
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new RopeEastState(enemy);
        }

        public void South()
        {
            enemy.State = new RopeSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new RopeWestState(enemy);
        }

        public void Idle()
        {
            enemy.State = new RopeIdleState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y - enemy.Velocity.Magnitude, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
