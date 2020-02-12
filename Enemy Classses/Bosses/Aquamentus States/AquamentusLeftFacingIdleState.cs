using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusLeftFacingIdleState : IState
    {
        IEnemy enemy;

        public AquamentusLeftFacingIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusLeftFacingIdleSprite();
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
            enemy.State = new AquamentusRightFacingIdleState(enemy);
        }
        public void West()
        {
            // Do nothing
        }
        public void BeDamaged()
        {
            // TODO
        }
        public void Attack()
        {
            enemy.State = new AquamentusLeftFacingAttackState(enemy);
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
