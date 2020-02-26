namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusWestAttackState : IState
    {
        IEnemy enemy;
        IProjectile fireball;
        ILevel Level;
        int count, maxCount;

        public AquamentusWestAttackState(ILevel level, IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusWestAttackSprite();

            Level = level;
            count = 0;
            maxCount = 60;
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
                fireball = new FireballProjectile(this.enemy.Position, 270);
                Level.ProjectileList.Add(fireball);
                enemy.State = new AquamentusWestIdleState(Level, enemy);
            }
        }
    }
}
