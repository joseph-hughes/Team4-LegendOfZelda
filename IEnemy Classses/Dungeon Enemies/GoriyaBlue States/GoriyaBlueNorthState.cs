using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States
{
    class GoriyaBlueNorthState : IState
    {
        IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();


        public GoriyaBlueNorthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaBlueNorthSprite();
            this.enemy.DestinationRectangle = new Rectangle((int)this.enemy.DestinationRectangle.X, (int)this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * utilities.width2), (int)(this.enemy.Scale * utilities.height));
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y - 1 % 600, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
            enemy.DestinationRectangle = new Rectangle((int)enemy.DestinationRectangle.X, (int)enemy.DestinationRectangle.Y, (int)(enemy.Scale * utilities.width2), (int)(enemy.Scale * utilities.height));
        }
    }
}
