namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseBlue_States
{
    class KeeseBlueIdleState : IState
    {
        IEnemy enemy;

        public KeeseBlueIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = 0;
        }

        public void North()
        {
            enemy.State = new KeeseBlueNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new KeeseBlueEastState(enemy);
        }

        public void South()
        {
            enemy.State = new KeeseBlueSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new KeeseBlueWestState(enemy);
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
