using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.ZolDarkGreen_States
{
    class ZolDarkGreenIdleState : IState
    {
        IEnemy enemy;

        public ZolDarkGreenIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = 0;
        }

        public void North()
        {
            enemy.State = new ZolDarkGreenNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new ZolDarkGreenEastState(enemy);
        }

        public void South()
        {
            enemy.State = new ZolDarkGreenSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new ZolDarkGreenWestState(enemy);
        }

        public void Idle()
        {
            // Do nothing
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
            // Do nothing
        }
    }
}
