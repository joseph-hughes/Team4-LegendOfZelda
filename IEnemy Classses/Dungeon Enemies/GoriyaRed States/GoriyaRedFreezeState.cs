namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedFreezeState : IState
    {
        private IEnemy enemy;
        private const int WIDTH = 14, HEIGHT = 16;

        public GoriyaRedFreezeState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = enemy.Sprite;
            this.enemy.DestinationRectangle = enemy.DestinationRectangle;
            this.enemy.Velocity.Magnitude = 0;
            this.enemy.Velocity.Direction = enemy.Velocity.Direction; ;
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }
        public void Freeze()
        {
            // Do nothing
        }
        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // Do nothing
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
            // Do nothing
        }
    }
}
