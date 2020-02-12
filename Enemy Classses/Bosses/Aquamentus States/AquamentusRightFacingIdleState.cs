using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusRightFacingIdleState : IState
    {
        IEnemy enemy;

        public AquamentusRightFacingIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusRightFacingIdleSprite();
        }
        public void South()
        {
            // Do nothing
        }
        public void North()
        {
            // Do nothing
        }
        public void East()
        {
            // Do nothing
        }
        public void West()
        {
            enemy.State = new AquamentusLeftFacingIdleState(enemy);
        }
        public void BeDamaged()
        {
            // TODO
        }
        public void Attack()
        {
            enemy.State = new AquamentusRightFacingAttackState(enemy);
        }
        public void UseItem()
        {
            // no action
        }
        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
