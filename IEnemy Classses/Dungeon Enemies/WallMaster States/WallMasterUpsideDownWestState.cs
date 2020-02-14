namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.WallMaster_States
{
    class WallMasterUpsideDownWestState : IState
    {
        IEnemy enemy;

        public WallMasterUpsideDownWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateWallMasterUpsideDownWestSprite();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new WallMasterUpsideDownEastState(enemy);
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
