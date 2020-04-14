using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedWestWalkingState : IState
    {
        IEnemy enemy;

        public GoriyaRedWestWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedWestSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * UtilityClass.Instance.GoriyaRed_WIDTH()), (int)(this.enemy.Scale * UtilityClass.Instance.GoriyaRed_HEIGHT()));
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.GoriyaRed_SPEED();
            this.enemy.Velocity.Direction = Vector.Orientation.West;
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
            // Do nothing
        }

        public void Idle()
        {
            enemy.State = new GoriyaRedWestIdleState(enemy);
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void Attack()
        {
            enemy.State = new GoriyaRedWestAttackState(enemy);
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X - enemy.Velocity.Magnitude, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
