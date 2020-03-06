namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoNorthWalkingState : IState
    {
        IEnemy enemy;

        public DodongoNorthWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoNorthWalkingSprite();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new DodongoEastWalkingState(enemy);
        }

        public void South()
        {
            enemy.State = new DodongoSouthWalkingState(enemy);
        }

        public void West()
        {
            enemy.State = new DodongoWestWalkingState(enemy);
        }

        public void Idle()
        {
            // TODO
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoNorthDamagedState(enemy);
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
            if (enemy.Position.Y > 1)
            {
                enemy.Position = new Microsoft.Xna.Framework.Vector2(enemy.Position.X, ((int)enemy.Position.Y - 1));
            }
            else
            {
                enemy.Position = new Microsoft.Xna.Framework.Vector2(enemy.Position.X, 568 - (int)enemy.Position.Y);
            }
        }
    }
}
