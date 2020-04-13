using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States
{
    class GoriyaBlueNorthAttackState : IState
    {
        IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
        private int count, maxcount;
        // Projectile item
        

        public GoriyaBlueNorthAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaBlueNorthSprite();
            this.enemy.DestinationRectangle = new Rectangle((int)this.enemy.DestinationRectangle.X, (int)this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * utilities.width), (int)(this.enemy.Scale * utilities.height));
            // Create boomerang

            count = utilities.count;
            maxcount = utilities.maxcount;
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
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            utilities.count++;
            if (utilities.count > utilities.maxcount)
            {
                enemy.State = new GoriyaBlueNorthState(enemy);
            }
        }
    }
}
