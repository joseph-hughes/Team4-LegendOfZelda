using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.ZolDarkGreen_States
{
    class ZolDarkGreenWestState : IState
    {
        IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();

        private int displacement;

        public ZolDarkGreenWestState(IEnemy enemy)
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
            enemy.State = new ZolDarkGreenIdleState(enemy);
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
            //enemy.DestinationRectangle = new Rectangle((enemy.DestinationRectangle.X - 10) % 800, enemy.DestinationRectangle.Y);
            if (displacement > 0)
            {
                if (enemy.DestinationRectangle.X > utilities.DELTA_DISPLACEMENT3)
                {
                    enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X - utilities.DELTA_DISPLACEMENT3, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                }
                else
                {
                    enemy.DestinationRectangle = new Rectangle(768 - (int)enemy.DestinationRectangle.X - utilities.DELTA_DISPLACEMENT3, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                }
                displacement -= utilities.DELTA_DISPLACEMENT3;
            }
            else
            {
                Idle();
            }
        }
    }
}
