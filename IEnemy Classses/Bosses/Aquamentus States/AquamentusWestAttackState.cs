namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusWestAttackState : IState
    {
        IEnemy enemy;
        int count, maxCount;

        public AquamentusWestAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusWestAttackSprite();

            count = 0;
            maxCount = 30;
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
            count++;
            if (count > maxCount)
            {
                // Create fireballs
                enemy.State = new AquamentusWestIdleState(enemy);
            }
        }
    }
}
