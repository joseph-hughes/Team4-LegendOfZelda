namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusEastIdleState : IState
    {
        private IEnemy enemy;
        public const int MAX_ATTACK_COUNTER = 60;

        public AquamentusEastIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusWestIdleSprite();
            this.enemy.Velocity.Magnitude = 2;
            this.enemy.Velocity.Direction = Vector.Orientation.East;
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
            enemy.State = new AquamentusWestIdleState(enemy);
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new AquamentusEastAttackState(enemy, MAX_ATTACK_COUNTER);
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            // Do nothing
        }
    }
}
