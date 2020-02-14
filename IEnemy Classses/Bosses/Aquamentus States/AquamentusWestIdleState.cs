namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusWestIdleState : IState
    {
        IEnemy enemy;

        public AquamentusWestIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusWestIdleSprite();
        }

        public void GoNorth()
        {
            // Do nothing
        }

        public void GoEast()
        {
            enemy.State = new AquamentusEastIdleState(enemy);
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
            enemy.State = new AquamentusWestAttackState(enemy);
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
