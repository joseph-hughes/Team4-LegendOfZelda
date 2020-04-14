using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Stalfos_States
{
    class StalfosIdleState : IState
    {
        private IEnemy enemy;

        public StalfosIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = 0;
        }

        public void North()
        {
            enemy.State = new StalfosNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new StalfosEastState(enemy);
        }

        public void South()
        {
            enemy.State = new StalfosSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new StalfosWestState(enemy);
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
