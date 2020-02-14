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

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new AquamentusEastAttackState(enemy);
        }

        public void South()
        {
            // Do nothing
        }
        public void West()
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
