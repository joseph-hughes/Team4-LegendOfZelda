using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.WallMasterUpsideDown_States
{
    class WallMasterUpsideDownSouthState : IState
    {
        private IEnemy enemy;
        private const int WIDTH = 16, HEIGHT = 16, SPEED = 1;
        private UtilityClass utilities = new UtilityClass();

        public WallMasterUpsideDownSouthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateWallMasterUpsideDownWestSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * WIDTH), (int)(this.enemy.Scale * HEIGHT));
            this.enemy.Velocity.Magnitude = SPEED;
            this.enemy.Velocity.Directon = Vector.Orientation.South;
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
            // Do nothing
        }

        public void West()
        {
            enemy.State = new WallMasterUpsideDownWestState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y + enemy.Velocity.Magnitude, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
