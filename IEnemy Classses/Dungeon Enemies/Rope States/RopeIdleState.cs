namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeIdleState : IState
    {
        IEnemy enemy;

        public RopeIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
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
            // Do nothing
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
            // Do nothing
        }
    }
}
