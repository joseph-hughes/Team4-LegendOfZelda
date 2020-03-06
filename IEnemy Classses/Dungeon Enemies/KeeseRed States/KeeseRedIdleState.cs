namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseRed_States
{
    class KeeseRedIdleState : IState
    {
        IEnemy enemy;

        public KeeseRedIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void North()
        {
            enemy.State = new KeeseRedNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new KeeseRedEastState(enemy);
        }

        public void South()
        {
            enemy.State = new KeeseRedSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new KeeseRedWestState(enemy);
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
