namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusEastAttackState : IState
    {
        IEnemy enemy;

        public AquamentusEastAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusEastAttackSprite();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            enemy.State = new AquamentusWestAttackState(enemy);
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
