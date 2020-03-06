namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.BladeTrap_States
{
    class BladeTrapIdleState : IState
    {
        IEnemy enemy;

        public BladeTrapIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void North()
        {
            enemy.State = new BladeTrapNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new BladeTrapEastState(enemy);
        }

        public void South()
        {
            enemy.State = new BladeTrapSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new BladeTrapWestState(enemy);
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
