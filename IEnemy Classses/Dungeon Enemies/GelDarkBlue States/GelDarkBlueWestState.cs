using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GelDarkBlue_States
{
    class GelDarkBlueWestState : IState
    {
        private IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
        private int displacement;

        public GelDarkBlueWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            displacement = utilities.MAX_DISPLACEMENT;
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
            enemy.State = new GelDarkBlueIdleState(enemy);
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
                if (enemy.DestinationRectangle.X > utilities.DELTA_DISPLACEMENT2)
                {
                    enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X - utilities.DELTA_DISPLACEMENT2, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                }
                else
                {
                    enemy.DestinationRectangle = new Rectangle(768 - enemy.DestinationRectangle.X - utilities.DELTA_DISPLACEMENT2, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                }
                displacement -= utilities.DELTA_DISPLACEMENT2;
            }
            else
            {
                Idle();
            }
        }
    }
}
