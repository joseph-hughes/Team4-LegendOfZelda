using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeSouthState : IState
    {
        private IEnemy enemy;
        private const int SPEED = 1;

        public RopeSouthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Direction = Vector.Orientation.South;
        }

        public void North()
        {
            enemy.State = new RopeNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new RopeEastState(enemy);
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            enemy.State = new RopeWestState(enemy);
        }
        public void Freeze()
        {
            enemy.State = new RopeFreezeState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y + enemy.Velocity.Magnitude, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
