using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedEastAttackState : IState
    {
        private IEnemy enemy;
        // Projectile item
        private const int WIDTH = 14, HEIGHT = 16, MAX_COUNTS = 60;
        private int count;

        public GoriyaRedEastAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedEastSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * WIDTH), (int)(this.enemy.Scale * HEIGHT));
            this.enemy.Velocity.Magnitude = 0;
            this.enemy.Velocity.Direction = Vector.Orientation.East;
            // Create boomerang
            count = MAX_COUNTS;
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
            count--;
            if (count <= 0)
            {
                enemy.State = new GoriyaRedEastWalkingState(enemy);
            }
        }
    }
}
