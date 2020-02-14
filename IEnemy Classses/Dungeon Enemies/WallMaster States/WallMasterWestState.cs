namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.WallMaster_States
{
    class WallMasterWestState : IState
    {
        IEnemy enemy;

        public WallMasterWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateWallMasterWestSprite();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new WallMasterEastState(enemy);
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
