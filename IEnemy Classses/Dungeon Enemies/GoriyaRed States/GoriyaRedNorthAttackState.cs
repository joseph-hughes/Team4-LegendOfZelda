using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedNorthAttackState : IState
    {
        private IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();

        // Projectile item
        private const int WIDTH = 13, HEIGHT = 16, MAX_COUNTS = 60;
        int count;

        public GoriyaRedNorthAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedNorthSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * WIDTH), (int)(this.enemy.Scale * HEIGHT));
            this.enemy.Velocity.Magnitude = 0;
            this.enemy.Velocity.Directon = Vector.Orientation.North;
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
            count--;
            if (count <= 0)
            {
                enemy.State = new GoriyaRedNorthWalkingState(enemy);
            }
        }
    }
}
