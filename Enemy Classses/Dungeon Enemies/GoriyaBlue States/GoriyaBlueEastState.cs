namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaBlue_States
{
    class GoriyaBlueEastState : IState
    {
        IEnemy enemy;

        public GoriyaBlueEastState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaBlueEastSprite();
        }

        public void GoNorth()
        {
            enemy.State = new GoriyaBlueNorthState(enemy);
        }

        public void GoEast()
        {
            // Do nothing
        }

        public void GoSouth()
        {
            enemy.State = new GoriyaBlueSouthState(enemy);
        }

        public void GoWest()
        {
            enemy.State = new GoriyaBlueWestState(enemy);
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            enemy.State = new GoriyaBlueEastAttackState(enemy);
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
