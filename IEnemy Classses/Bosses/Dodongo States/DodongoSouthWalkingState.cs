namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoSouthWalkingState : IState
    {
        IEnemy enemy;

        public DodongoSouthWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoSouthWalkingSprite();
        }

        public void North()
        {
            enemy.State = new DodongoNorthWalkingState(enemy);
        }

        public void East()
        {
            enemy.State = new DodongoEastWalkingState(enemy);
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            enemy.State = new DodongoWestWalkingState(enemy);
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoSouthDamagedState(enemy);
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
            enemy.Position = new Microsoft.Xna.Framework.Vector2(enemy.Position.X, ((int)enemy.Position.Y + 1) % 600);
        }
    }
}
