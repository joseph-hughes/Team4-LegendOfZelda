namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusEastIdleState : IState
    {
        IEnemy enemy;

        public AquamentusEastIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusEastIdleSprite();
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
            enemy.State = new AquamentusWestIdleState(enemy);
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new AquamentusEastAttackState(enemy);
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
