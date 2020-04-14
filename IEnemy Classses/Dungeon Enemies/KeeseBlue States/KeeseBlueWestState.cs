using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseBlue_States
{
    class KeeseBlueWestState : IState
    {
        private IEnemy enemy;

        public KeeseBlueWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.KeeseBlue_SPEED();
            this.enemy.Velocity.Direction = Vector.Orientation.West;
        }

        public void North()
        {
            enemy.State = new KeeseBlueNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new KeeseBlueEastState(enemy);
        }

        public void South()
        {
            enemy.State = new KeeseBlueSouthState(enemy);
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            enemy.State = new KeeseBlueIdleState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X - enemy.Velocity.Magnitude, enemy.DestinationRectangle.Y, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
