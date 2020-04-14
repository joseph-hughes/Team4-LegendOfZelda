using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Rope_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeIdleState : IState
    {
        private IEnemy enemy;

        public RopeIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = 0;
        }

        public void North()
        {
            enemy.State = new RopeNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new RopeEastState(enemy);
        }

        public void South()
        {
            enemy.State = new RopeSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new RopeWestState(enemy);
        }

        public void Idle()
        {
            enemy.Velocity.Magnitude = 0;
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
