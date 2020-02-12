using Team4_LegendOfZelda.IEnemy_Classses.Bosses;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States
{
    class AquamentusLeftFacingAttackState : IState
    {
        IEnemy enemy;

        public AquamentusLeftFacingAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateAquamentusLeftFacingAttackSprite();
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
            enemy.State = new AquamentusRightFacingAttackState(enemy);
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
