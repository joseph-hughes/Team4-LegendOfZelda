using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoLeftFacingWalkingState : IEnemyState
    {
        IEnemy enemy;

        public DodongoLeftFacingWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoLeftFacingWalkingSprite();
        }

        public void GoLeft()
        {
            // Do nothing
        }

        public void GoRight()
        {
            enemy.State = new DodongoRightFacingWalkingState(enemy);
        }

        public void GoUp()
        {
            enemy.State = new DodongoUpWalkingState(enemy);
        }

        public void GoDown()
        {
            enemy.State = new DodongoDownWalkingState(enemy);
        }

        public void Attack()
        {
            // Do nothing
        }

        public void BeHit()
        {
            enemy.State = new DodongoLeftFacingHitState(enemy);
        }
    }
}
