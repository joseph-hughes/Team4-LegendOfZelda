namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoNorthWalkingState : IState
    {
        IEnemy enemy;

        public DodongoNorthWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoNorthWalkingSprite();
        }

        public void GoNorth()
        {
            // Do nothing
        }

        public void GoEast()
        {
            enemy.State = new DodongoEastWalkingState(enemy);
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
            enemy.State = new DodongoNorthDamagedState(enemy);
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
