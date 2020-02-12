using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusRightFacingIdleState : IEnemyState
    {
        IEnemy enemy;

        public AquamentusRightFacingIdleState(Aquamentus aquamentus)
        {
            enemy = aquamentus;
        }

        public void GoLeft()
        {
            enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusLeftFacingIdleSprite();
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
            enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusRightFacingAttackSprite();
        }

        public void BeHit()
        {
            // TODO
        }
    }
}
