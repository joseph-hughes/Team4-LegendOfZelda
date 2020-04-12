using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeNorthState : IState
    {
        IEnemy enemy;
        private const int MAX_DISPLACEMENT = 48, DELTA_DISPLACEMENT = 2;
        private int displacement;

        public RopeNorthState(IEnemy enemy)
        {
            this.enemy = enemy;
            displacement = MAX_DISPLACEMENT;
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
            enemy.State = new RopeIdleState(enemy);
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
            //enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, ((int)enemy.DestinationRectangle.Y - 2) % 600);
            if (displacement > 0)
            {
                if (enemy.DestinationRectangle.Y > DELTA_DISPLACEMENT)
                {
                    enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, (int)enemy.DestinationRectangle.Y - DELTA_DISPLACEMENT, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                }
                else
                {
                    enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, 528 - (int)enemy.DestinationRectangle.Y - DELTA_DISPLACEMENT, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                }
                displacement -= DELTA_DISPLACEMENT;
            }
            else
            {
                Idle();
            }
        }
    }
}
