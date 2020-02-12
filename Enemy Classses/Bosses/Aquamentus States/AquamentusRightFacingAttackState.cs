using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusRightFacingAttackState : IState
    {
        IEnemy enemy;

        public AquamentusRightFacingAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusRightFacingAttackSprite();
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
            enemy.State = new AquamentusLeftFacingAttackState(enemy);
        }
        public void BeDamaged()
        {
            // TODO
        }
        public void Attack()
        {
            // Do nothing
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
