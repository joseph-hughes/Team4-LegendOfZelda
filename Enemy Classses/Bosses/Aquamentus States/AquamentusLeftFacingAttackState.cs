using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusLeftFacingAttackState : IEnemyState
    {
        IEnemy enemy;

        public AquamentusLeftFacingAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusLeftFacingAttackSprite();
        }

        public void GoLeft()
        {
            // Do nothing
        }

        public void GoRight()
        {
            enemy.State = new AquamentusRightFacingAttackState(enemy);
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
