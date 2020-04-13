using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States
{
    class GoriyaBlueEastState : IState
    {
        IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
      

        public GoriyaBlueEastState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaBlueEastSprite();
            this.enemy.DestinationRectangle = new Rectangle((int)this.enemy.DestinationRectangle.X, (int)this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * utilities.width), (int)(this.enemy.Scale * utilities.height));
        }

        public void North()
        {
            enemy.State = new GoriyaBlueNorthState(enemy);
        }

        public void East()
        {
            // Do nothing
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
            enemy.State = new GoriyaBlueEastAttackState(enemy);
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            enemy.DestinationRectangle = new Rectangle((enemy.DestinationRectangle.X + 1) % 800, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
            enemy.DestinationRectangle = new Rectangle((int)enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y, (int)(enemy.Scale * utilities.width), (int)(enemy.Scale * utilities.height));
        }
    }
}
