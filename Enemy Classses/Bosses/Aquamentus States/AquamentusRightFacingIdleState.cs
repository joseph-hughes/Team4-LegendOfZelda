using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusRightFacingIdleState : IEnemyState
    {
        IEnemy enemy;

        public AquamentusRightFacingIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusRightFacingIdleSprite();
        }

        public void GoLeft()
        {
            enemy.State = new AquamentusLeftFacingIdleState(enemy);
        }

        public void GoRight()
        {
            // Do nothing
        }

        public void GoUp()
        {
            // Do nothing
        }

        public void GoDown()
        {
            // Do nothing
        }

        public void Attack()
        {
            enemy.State = new AquamentusRightFacingAttackState(enemy);
        }

        public void BeHit()
        {
            // TODO
        }
    }
}
