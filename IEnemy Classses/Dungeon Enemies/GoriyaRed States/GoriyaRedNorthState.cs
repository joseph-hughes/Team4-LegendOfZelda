using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedNorthState : IState
    {
        IEnemy enemy;
        private const int width = 13;
        private const int height = 16;

        public GoriyaRedNorthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedNorthSprite();
            this.enemy.Rectangle = new Rectangle((int)this.enemy.Position.X, (int)this.enemy.Position.Y, (int)(this.enemy.Scale * width), (int)(this.enemy.Scale * height));
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new GoriyaRedEastState(enemy);
        }

        public void South()
        {
            enemy.State = new GoriyaRedSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new GoriyaRedWestState(enemy);
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new GoriyaRedNorthAttackState(enemy);
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            enemy.Position = new Vector2(enemy.Position.X, ((int)enemy.Position.Y - 1) % 600);
            enemy.Rectangle = new Rectangle((int)enemy.Position.X, (int)enemy.Position.Y, (int)(enemy.Scale * width), (int)(enemy.Scale * height));
        }
    }
}
