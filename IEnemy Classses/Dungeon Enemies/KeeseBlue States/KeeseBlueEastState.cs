using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseBlue_States
{
    class KeeseBlueEastState : IState
    {
        private IEnemy enemy;
        private const int MAX_DISPLACEMENT = 48, DELTA_DISPLACEMENT = 2;
        private int displacement;

        public KeeseBlueEastState(IEnemy enemy)
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
                enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X + DELTA_DISPLACEMENT, this.enemy.DestinationRectangle.Y, this.enemy.DestinationRectangle.Width, this.enemy.DestinationRectangle.Height); 
                displacement -= DELTA_DISPLACEMENT;
            }
            else
            {
                Idle();
            }
        }
    }
}
