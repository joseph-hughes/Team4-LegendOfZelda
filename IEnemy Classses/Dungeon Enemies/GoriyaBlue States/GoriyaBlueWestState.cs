namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States
{
    class GoriyaBlueWestState : IState
    {
        IEnemy enemy;

        public GoriyaBlueWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaBlueWestSprite();
        }

        public void GoNorth()
        {
            enemy.State = new GoriyaBlueNorthState(enemy);
        }

        public void GoEast()
        {
            enemy.State = new GoriyaBlueEastState(enemy);
        }

        public void GoSouth()
        {
            enemy.State = new GoriyaBlueSouthState(enemy);
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
            enemy.State = new GoriyaBlueWestAttackState(enemy);
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
