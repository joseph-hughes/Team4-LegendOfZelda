using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Rope_States;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeWestState : IState
    {
        private IEnemy enemy;

        public RopeWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateRopeWestSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * UtilityClass.Instance.Rope_WIDTH()), (int)(this.enemy.Scale * UtilityClass.Instance.Rope_HEIGHT()));
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.Rope_SPEED();
            this.enemy.Velocity.Direction = Vector.Orientation.West;
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
            enemy.State = new RopeSouthState(enemy);
        }

        public void West()
        {
            // Do nothing
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X - enemy.Velocity.Magnitude, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
