using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.WallMaster_States
{
    class WallMasterUpsideDownWestState : IState
    {
        IEnemy enemy;
        private const int width = 16;
        private const int height = 16;

        public WallMasterUpsideDownWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateWallMasterUpsideDownWestSprite();
            this.enemy.Rectangle = new Rectangle((int)this.enemy.Position.X, (int)this.enemy.Position.Y, (int)(this.enemy.Scale * width), (int)(this.enemy.Scale * height));
        }

        public void North()
        {
            // Do nothing
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
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            enemy.Rectangle = new Rectangle((int)enemy.Position.X, (int)enemy.Position.Y, (int)(enemy.Scale * width), (int)(enemy.Scale * height));
        }
    }
}
