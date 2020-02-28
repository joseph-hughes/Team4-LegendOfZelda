using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoNorthWalkingState : IState
    {
        IEnemy enemy;
        private const int width = 15;
        private const int height = 16;

        public DodongoNorthWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoNorthWalkingSprite();
            this.enemy.Rectangle = new Rectangle((int)this.enemy.Position.X, (int)this.enemy.Position.Y, (int)(this.enemy.Scale * width), (int)(this.enemy.Scale * height));
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
            // TODO
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
            enemy.Position = new Microsoft.Xna.Framework.Vector2(enemy.Position.X, ((int)enemy.Position.Y - 1) % 600);
            enemy.Rectangle = new Rectangle((int)enemy.Position.X, (int)enemy.Position.Y, (int)(enemy.Scale * width), (int)(enemy.Scale * height));
        }
    }
}
