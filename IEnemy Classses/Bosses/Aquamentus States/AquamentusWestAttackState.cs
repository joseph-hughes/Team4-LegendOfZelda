namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusWestAttackState : IState
    {
        IEnemy enemy;

        public AquamentusWestAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusWestAttackSprite();
        }

        public void GoNorth()
        {
            // Do nothing
        }

        public void GoEast()
        {
            enemy.State = new AquamentusEastAttackState(enemy);
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
