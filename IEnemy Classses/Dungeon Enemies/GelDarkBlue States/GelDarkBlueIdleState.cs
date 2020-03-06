namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GelDarkBlue_States
{
    class GelDarkBlueIdleState : IState
    {
        IEnemy enemy;

        public GelDarkBlueIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void North()
        {
            enemy.State = new GelDarkBlueNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new GelDarkBlueEastState(enemy);
        }

        public void South()
        {
            enemy.State = new GelDarkBlueSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new GelDarkBlueWestState(enemy);
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
