using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusLeftFacingAttackState : IEnemyState
    {
        IEnemy enemy;

        public AquamentusLeftFacingAttackState(Aquamentus aquamentus)
        {
            enemy = aquamentus;
        }

        public void GoLeft()
        {
            // Do nothing
        }

        public void GoRight()
        {
            enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusRightFacingAttackSprite();
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
