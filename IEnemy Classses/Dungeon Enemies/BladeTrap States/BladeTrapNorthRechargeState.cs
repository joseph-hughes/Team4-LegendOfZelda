using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.BladeTrap_States
{
    class BladeTrapNorthRechargeState : IState
    {
        private IEnemy enemy;

        public BladeTrapNorthRechargeState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.BladeTrapRecharge_Speed();
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
            enemy.State = new BladeTrapIdleState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y - enemy.Velocity.Magnitude, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
