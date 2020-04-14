using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses.Dodongo_States
{
    class DodongoNorthWalkingState : IState
    {
        IEnemy enemy;

        public DodongoNorthWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoNorthWalkingSprite();

            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * this.enemy.Sprite.SourceRectangle.Width), (int)(this.enemy.Scale * this.enemy.Sprite.SourceRectangle.Height));
            this.enemy.Velocity.Magnitude = 2;
            this.enemy.Velocity.Directon = Vector.Orientation.North;
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new DodongoEastWalkingState(enemy);
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
            enemy.State = new DodongoNorthDamagedState(enemy);
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
