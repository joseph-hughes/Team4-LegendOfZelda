using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GelDarkBlue_States
{
    class GelDarkBlueSouthState : IState
    {
        private IEnemy enemy;

        public GelDarkBlueSouthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.GelDarkBlue_Speed();
            this.enemy.Velocity.Direction = Vector.Orientation.South;
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
            enemy.State = new GelDarkBlueIdleState(enemy);
        }

        public void BeDamaged()
        {
            // Nothing
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y + UtilityClass.Instance.GelDarkBlue_Speed(), enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
