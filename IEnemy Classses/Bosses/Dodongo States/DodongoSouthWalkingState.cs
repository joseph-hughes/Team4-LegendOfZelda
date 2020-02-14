namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoSouthWalkingState : IState
    {
        IEnemy enemy;

        public DodongoSouthWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoSouthWalkingSprite();
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
            // Do nothing
        }

        public void GoWest()
        {
            enemy.State = new DodongoWestWalkingState(enemy);
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoSouthDamagedState(enemy);
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
