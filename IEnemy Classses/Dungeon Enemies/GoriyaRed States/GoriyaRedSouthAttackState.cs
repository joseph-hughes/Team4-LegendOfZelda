namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedSouthAttackState : IState
    {
        IEnemy enemy;
        // Projectile item

        public GoriyaRedSouthAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedSouthSprite();
            // Create boomerang
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
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
            // Do nothing
        }

        public void Update()
        {
            // TODO
        }
    }
}
