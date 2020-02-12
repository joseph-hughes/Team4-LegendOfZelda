using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusLeftFacingIdleState : IEnemyState
    {
        IEnemy enemy;

        public AquamentusLeftFacingIdleState(Aquamentus aquamentus)
        {
            enemy = aquamentus;
        }

        public void GoLeft()
        {
            // Do nothing
        }

        public void GoRight()
        {
            enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusRightFacingIdleSprite();
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
            enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusLeftFacingAttackSprite();
        }

        public void BeHit()
        {
            // TODO
        }
    }
}
