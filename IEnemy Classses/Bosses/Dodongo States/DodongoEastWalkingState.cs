using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses.Dodongo_States
{
    class DodongoEastWalkingState : IState
    {
        IEnemy enemy;

        public DodongoEastWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoEastWalkingSprite();

            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * this.enemy.Sprite.SourceRectangle.Width), (int)(this.enemy.Scale * this.enemy.Sprite.SourceRectangle.Height));
            this.enemy.Velocity.Magnitude = 2;
            this.enemy.Velocity.Direction = Vector.Orientation.East;
        }

        public void North()
        {
            enemy.State = new DodongoNorthWalkingState(enemy);
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            enemy.State = new DodongoSouthWalkingState(enemy);
        }

        public void West()
        {
            enemy.State = new DodongoWestWalkingState(enemy);
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoEastDamagedState(enemy);
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
