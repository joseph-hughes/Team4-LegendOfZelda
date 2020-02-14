namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedSouthState : IState
    {
        IEnemy enemy;

        public GoriyaRedSouthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedSouthSprite();
        }

        public void GoNorth()
        {
            enemy.State = new GoriyaRedNorthState(enemy);
        }

        public void GoEast()
        {
            enemy.State = new GoriyaRedEastState(enemy);
        }

        public void GoSouth()
        {
            // Do nothing
        }

        public void GoWest()
        {
            enemy.State = new GoriyaRedWestState(enemy);
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new GoriyaRedSouthAttackState(enemy);
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
