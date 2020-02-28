using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedWestState : IState
    {
        IEnemy enemy;
        private const int width = 14;
        private const int height = 16;

        public GoriyaRedWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedWestSprite();
            this.enemy.Rectangle = new Rectangle((int)this.enemy.Position.X, (int)this.enemy.Position.Y, (int)(this.enemy.Scale * width), (int)(this.enemy.Scale * height));
        }

        public void North()
        {
            enemy.State = new GoriyaRedNorthState(enemy);
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
            // Do nothing
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
            enemy.State = new GoriyaRedWestAttackState(enemy);
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            enemy.Position = new Vector2(((int)enemy.Position.X - 1) % 800, enemy.Position.Y);
            enemy.Rectangle = new Rectangle((int)enemy.Position.X, (int)enemy.Position.Y, (int)(enemy.Scale * width), (int)(enemy.Scale * height));
        }
    }
}
