using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedNorthWalkingState : IState
    {
        IEnemy enemy;

        public GoriyaRedNorthWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedNorthSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * UtilityClass.Instance.GoriyaRed_WIDTH2()), (int)(this.enemy.Scale * UtilityClass.Instance.GoriyaRed_HEIGHT()));
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.GoriyaRed_SPEED();
            this.enemy.Velocity.Direction = Vector.Orientation.North;
        }

        public void North()
        {
            // Do nothing
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
            enemy.State = new GoriyaRedNorthIdleState(enemy);
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void Attack()
        {
            enemy.State = new GoriyaRedNorthAttackState(enemy);
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y - enemy.Velocity.Magnitude, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
