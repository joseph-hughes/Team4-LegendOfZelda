namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoWestWalkingState : IState
    {
        IEnemy enemy;

        public DodongoWestWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoWestWalkingSprite();
        }

        public void GoNorth()
        {
            enemy.State = new DodongoNorthWalkingState(enemy);
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
            // Do nothing
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoWestDamagedState(enemy);
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
