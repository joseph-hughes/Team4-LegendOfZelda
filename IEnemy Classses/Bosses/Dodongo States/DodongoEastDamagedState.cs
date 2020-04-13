using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoEastDamagedState : IState
    {
        IEnemy enemy;
        private const int width = 32;
        private UtilityClass utilities = new UtilityClass();
        private const int height = 16;
        int count, maxCount;

        public DodongoEastDamagedState(IEnemy enemy)
        {
            this.enemy = enemy;

            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoEastDamagedSprite();
            this.enemy.DestinationRectangle = new Rectangle((int)this.enemy.DestinationRectangle.X, (int)this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * width), (int)(this.enemy.Scale * height));

            count = utilities.count;
            maxCount = utilities.maxcount2;
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
            count++;
            if (count > maxCount)
            {
                enemy.State = new DodongoEastWalkingState(enemy);
            }
        }
    }
}
