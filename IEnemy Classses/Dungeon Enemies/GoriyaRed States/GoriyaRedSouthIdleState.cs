using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedSouthIdleState : IState
    {
        IEnemy enemy;
        private const int WIDTH = 13, HEIGHT = 16;

        public GoriyaRedSouthIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedSouthSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * WIDTH), (int)(this.enemy.Scale * HEIGHT));
            this.enemy.Velocity.Magnitude = 0;
            this.enemy.Velocity.Direction = Vector.Orientation.South;
        }

        public void North()
        {
            enemy.State = new GoriyaRedNorthWalkingState(enemy);
        }

        public void East()
        {
            enemy.State = new GoriyaRedEastWalkingState(enemy);
        }

        public void South()
        {
            enemy.State = new GoriyaRedSouthWalkingState(enemy);
        }

        public void West()
        {
            enemy.State = new GoriyaRedWestWalkingState(enemy);
        }
        public void Idle()
        {
            enemy.Velocity.Magnitude = 0;
        }

        public void BeDamaged()
        {
            // Do nothing
        }
        public void Freeze()
        {
            enemy.State = new GoriyaRedFreezeState(enemy);
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
            // Do nothing
        }
    }
}
