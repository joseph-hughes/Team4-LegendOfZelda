namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoSouthDamagedState : IState
    {
        IEnemy enemy;
        int count, maxCount;

        public DodongoSouthDamagedState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoSouthDamagedSprite();

            count = 0;
            maxCount = 120;
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

        public void Idle()
        {
            // TODO
        }

        public void BeDamaged()
        {
            // Do nothing
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
                enemy.State = new DodongoSouthWalkingState(enemy);
            }
        }
    }
}
