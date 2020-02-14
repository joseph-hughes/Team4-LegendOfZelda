namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedEastState : IState
    {
        IEnemy enemy;

        public GoriyaRedEastState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedEastSprite();
        }

        public void GoNorth()
        {
            enemy.State = new GoriyaRedNorthState(enemy);
        }

        public void GoEast()
        {
            // Do nothing
        }

        public void GoSouth()
        {
            enemy.State = new GoriyaRedSouthState(enemy);
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
            enemy.State = new GoriyaRedEastAttackState(enemy);
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
