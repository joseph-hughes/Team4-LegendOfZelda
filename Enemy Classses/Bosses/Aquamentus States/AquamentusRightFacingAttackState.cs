using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusRightFacingAttackState : IEnemyState
    {
        IEnemy enemy;

        public AquamentusRightFacingAttackState(Aquamentus aquamentus)
        {
            enemy = aquamentus;
        }

        public void GoLeft()
        {
            enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusLeftFacingAttackSprite();
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
            // Do nothing
        }

        public void BeHit()
        {
            // TODO
        }
    }
}
