using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.BladeTrap_States
{
    class BladeTrapNorthState : IState
    {
        private IEnemy enemy;
        private static int MAX_DISPLACEMENT = 240;
        private int displacement;

        public BladeTrapNorthState(IEnemy enemy)
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
            enemy.State = new BladeTrapIdleState(enemy);
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
                if (enemy.Position.Y > 16)
                {
                    enemy.Position = new Vector2(enemy.Position.X, (int)enemy.Position.Y - 16);
                }
                else
                {
                    enemy.Position = new Vector2(enemy.Position.X, 528 - (int)enemy.Position.Y - 16);
                }
                displacement -= 16;
            }
            else
            {
                Idle();
            }
        }
    }
}
