using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.WallMasterUpsideDown_States
{
    class WallMasterUpsideDownWestState : IState
    {
        private IEnemy enemy;

        public WallMasterUpsideDownWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateWallMasterUpsideDownWestSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * UtilityClass.Instance.WallMaster_WIDTH()), (int)(this.enemy.Scale * UtilityClass.Instance.WallMaster_HEIGHT()));
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.WallMaster_SPEED();
            this.enemy.Velocity.Direction = Vector.Orientation.West;
        }

        public void North()
        {
            enemy.State = new WallMasterUpsideDownNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new WallMasterUpsideDownEastState(enemy);
        }

        public void South()
        {
            enemy.State = new WallMasterUpsideDownSouthState(enemy);
        }

        public void West()
        {
            // Do nothing
        }
        public void Idle()
        {
            enemy.State = new WallMasterUpsideDownIdleState(enemy);
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
