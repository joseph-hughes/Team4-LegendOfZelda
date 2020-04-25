using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses.Dodongo_States
{
    class DodongoWestDamagedState : IState
    {
        IEnemy enemy;
        int damageCounter;

        public DodongoWestDamagedState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoWestDamagedSprite();

            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * this.enemy.Sprite.SourceRectangle.Width), (int)(this.enemy.Scale * this.enemy.Sprite.SourceRectangle.Height));
            this.enemy.Velocity.Magnitude = 0;
            this.enemy.Velocity.Direction = Vector.Orientation.West;
            damageCounter = 120;
            SFXFactory.Instance.PlayBossZapped();
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
        public void Freeze()
        {
            // Do nothing
        }
        public void Idle()
        {
            // Do nothing
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
            damageCounter--;
            if (damageCounter <= 0)
            {
                enemy.State = new DodongoWestWalkingState(enemy);
            }
        }
    }
}
