namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.WallMaster_States
{
    class WallMasterUpsideDownEastState : IState
    {
        IEnemy enemy;

        public WallMasterUpsideDownEastState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateWallMasterUpsideDownEastSprite();
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
            enemy.State = new WallMasterUpsideDownWestState(enemy);
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
