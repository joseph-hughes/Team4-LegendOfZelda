using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;
namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedEastAttackState : IState
    {
        IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
        private const int utilities.width = 14;
        private const int height = 16;
        // Projectile item
        int count, maxCount;

        public GoriyaRedEastAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedEastSprite();
            this.enemy.DestinationRectangle = new Rectangle((int)this.enemy.DestinationRectangle.X, (int)this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * utilities.width), (int)(this.enemy.Scale * height));
            // Create boomerang

            count = utilities.count;
            maxCount = utilities.maxcount;
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
            count++;
            if (count > maxCount)
            {
                enemy.State = new GoriyaRedEastState(enemy);
            }
        }
    }
}
