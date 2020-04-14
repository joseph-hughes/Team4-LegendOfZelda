using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.WallMaster_States
{
    class WallMasterWestState : IState
    {
        private IEnemy enemy;
        private const int WIDTH = 16, HEIGHT = 16, SPEED = 1;

        public WallMasterWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateWallMasterWestSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * WIDTH), (int)(this.enemy.Scale * HEIGHT));
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Direction = Vector.Orientation.West;
        }

        public void North()
        {
            enemy.State = new WallMasterNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new WallMasterEastState(enemy);
        }

        public void South()
        {
            enemy.State = new WallMasterSouthState(enemy);
        }

        public void West()
        {
            // Do nothing
        }
        public void Idle()
        {
            enemy.State = new WallMasterIdleState(enemy);
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
