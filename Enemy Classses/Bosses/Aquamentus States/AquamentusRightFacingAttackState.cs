using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusRightFacingAttackState : IEnemyState
    {
        IEnemy enemy;

        public AquamentusRightFacingAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusRightFacingAttackSprite();
        }

        public void GoLeft()
        {
            enemy.State = new AquamentusLeftFacingAttackState(enemy);
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

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
