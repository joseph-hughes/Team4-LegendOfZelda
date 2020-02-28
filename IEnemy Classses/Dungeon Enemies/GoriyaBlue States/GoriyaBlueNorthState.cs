using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States
{
    class GoriyaBlueNorthState : IState
    {
        IEnemy enemy;
        private const int width = 13;
        private const int height = 16;

        public GoriyaBlueNorthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaBlueNorthSprite();
            this.enemy.Rectangle = new Rectangle((int)this.enemy.Position.X, (int)this.enemy.Position.Y, (int)(this.enemy.Scale * width), (int)(this.enemy.Scale * height));
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new GoriyaBlueEastState(enemy);
        }

        public void South()
        {
            enemy.State = new GoriyaBlueSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new GoriyaBlueWestState(enemy);
        }

        public void Idle()
        {
            // TODO
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new GoriyaBlueNorthAttackState(enemy);
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
