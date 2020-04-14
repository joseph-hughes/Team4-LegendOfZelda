using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseBlue_States
{
    class KeeseBlueEastState : IState
    {
        private IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
        private int displacement;

        public KeeseBlueEastState(IEnemy enemy)
        {
            this.enemy = enemy;
            displacement = utilities.MAX_DISPLACEMENT2;
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
            enemy.State = new KeeseBlueIdleState(enemy);
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
            if (displacement > 0)
            {
                //enemy.DestinationRectangle = new Rectangle((enemy.DestinationRectangle.X + 2) % 800, enemy.DestinationRectangle.Y);
                enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X + utilities.DELTA_DISPLACEMENT2, this.enemy.DestinationRectangle.Y, this.enemy.DestinationRectangle.Width, this.enemy.DestinationRectangle.Height); 
                displacement -= utilities.DELTA_DISPLACEMENT2;
            }
            else
            {
                Idle();
            }
        }
    }
}
