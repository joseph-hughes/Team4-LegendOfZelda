using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.WallMaster_States
{
    class WallMasterSouthState : IState
    {
        private IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
        private int displacement;

        public WallMasterSouthState(IEnemy enemy)
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
            enemy.State = new WallMasterIdleState(enemy);
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
            //enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, ((int)enemy.DestinationRectangle.Y + 2) % 600);
            if (displacement > 0)
            {
                enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y + utilities.DELTA_DISPLACEMENT2, this.enemy.DestinationRectangle.Width, this.enemy.DestinationRectangle.Height);
                displacement -= utilities.DELTA_DISPLACEMENT2;
            }
            else
            {
                Idle();
            }
        }
    }
}
