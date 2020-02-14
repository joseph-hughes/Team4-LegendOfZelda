namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States
{
    class GoriyaBlueWestAttackState : IState
    {
        IEnemy enemy;
        // Projectile item

        public GoriyaBlueWestAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaBlueWestSprite();
            // Create boomerang
        }

        public void GoNorth()
        {
            // Do nothing
        }

        public void GoEast()
        {
            // Do nothing
        }

        public void GoSouth()
        {
            // Do nothing
        }

        public void GoWest()
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
