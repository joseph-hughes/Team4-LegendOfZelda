namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States
{
    class GoriyaBlueNorthState : IState
    {
        IEnemy enemy;

        public GoriyaBlueNorthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaBlueNorthSprite();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new GoriyaBlueEastState(enemy);
        }

        public void South()
        {
            enemy.State = new GoriyaBlueSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new GoriyaBlueWestState(enemy);
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new GoriyaBlueNorthAttackState(enemy);
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
