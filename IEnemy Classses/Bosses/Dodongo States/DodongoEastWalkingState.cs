namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoEastWalkingState : IState
    {
        IEnemy enemy;

        public DodongoEastWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoEastWalkingSprite();
        }

        public void GoNorth()
        {
            enemy.State = new DodongoNorthWalkingState(enemy);
        }

        public void GoEast()
        {
            // Do nothing
        }

        public void GoSouth()
        {
            enemy.State = new DodongoSouthWalkingState(enemy);
        }

        public void GoWest()
        {
            enemy.State = new DodongoWestWalkingState(enemy);
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoEastDamagedState(enemy);
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
