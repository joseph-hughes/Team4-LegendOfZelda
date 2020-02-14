namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeWestState : IState
    {
        IEnemy enemy;

        public RopeWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateRopeWestSprite();
        }

        public void GoNorth()
        {
            // Do nothing
        }

        public void GoEast()
        {
            enemy.State = new RopeEastState(enemy);
        }

        public void GoSouth()
        {
            // Do nothing
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
            // Do nothing
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
