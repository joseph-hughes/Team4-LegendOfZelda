using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusWestAttackState : IState
    {
        private IEnemy enemy;
        private int attackCounter;
        public const int MAX_ATTACK_COUNTER = 60;
        private UtilityClass utilities = new UtilityClass();

        public AquamentusWestAttackState(IEnemy enemy, int attackCounter)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusWestAttackSprite();
            this.enemy.Velocity.Magnitude = 2;
            this.enemy.Velocity.Directon = Vector.Orientation.West;

            if (attackCounter > 0)
            {
                this.attackCounter = attackCounter;
            }
            else
            {
                this.attackCounter = MAX_ATTACK_COUNTER;
            }
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new AquamentusEastAttackState(enemy, attackCounter);
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
            attackCounter--;
            if (attackCounter <= 0)
            {
                // Create fireballs
                enemy.State = new AquamentusWestIdleState(enemy);
            }
        }
    }
}
