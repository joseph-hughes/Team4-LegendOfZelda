namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeEastState : IState
    {
        IEnemy enemy;

        public RopeEastState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateRopeEastSprite();
        }

        public void GoNorth()
        {
            // Do nothing
        }

        public void GoEast()
        {
            // Do nothing
        }

        public void GoSouth()
        {
            // Do nothing
        }

        public void GoWest()
        {
            enemy.State = new RopeWestState(enemy);
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
