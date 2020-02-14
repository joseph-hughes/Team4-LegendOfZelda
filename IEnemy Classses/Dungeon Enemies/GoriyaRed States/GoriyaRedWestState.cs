namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedWestState : IState
    {
        IEnemy enemy;

        public GoriyaRedWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedWestSprite();
        }

        public void GoNorth()
        {
            enemy.State = new GoriyaRedNorthState(enemy);
        }

        public void GoEast()
        {
            enemy.State = new GoriyaRedEastState(enemy);
        }

        public void GoSouth()
        {
            enemy.State = new GoriyaRedSouthState(enemy);
        }

        public void GoWest()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new GoriyaRedWestAttackState(enemy);
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            // TODO
        }
    }
}
