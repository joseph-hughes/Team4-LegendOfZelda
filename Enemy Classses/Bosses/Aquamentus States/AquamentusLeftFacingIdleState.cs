using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusLeftFacingIdleState : IEnemyState
    {
        IEnemy enemy;

        public AquamentusLeftFacingIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusLeftFacingIdleSprite();
        }

        public void GoLeft()
        {
            // Do nothing
        }

        public void GoRight()
        {
            enemy.State = new AquamentusRightFacingIdleState(enemy);
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
            enemy.State = new AquamentusLeftFacingAttackState(enemy);
        }

        public void BeHit()
        {
            // TODO
        }
    }
}
