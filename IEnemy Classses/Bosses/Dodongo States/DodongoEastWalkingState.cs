namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoEastWalkingState : IState
    {
        IEnemy enemy;

        public DodongoEastWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoEastWalkingSprite();
        }

        public void North()
        {
            enemy.State = new DodongoNorthWalkingState(enemy);
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            enemy.State = new DodongoSouthWalkingState(enemy);
        }

        public void West()
        {
            enemy.State = new DodongoWestWalkingState(enemy);
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoEastDamagedState(enemy);
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
            enemy.Position = new Microsoft.Xna.Framework.Vector2(((int)enemy.Position.X + 1) % 800, enemy.Position.Y);
        }
    }
}
