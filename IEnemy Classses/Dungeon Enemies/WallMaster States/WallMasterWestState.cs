using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.WallMaster_States
{
    class WallMasterWestState : IState
    {
        IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();

       
        public WallMasterWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateWallMasterWestSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, (int)this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * utilities.width3), (int)(this.enemy.Scale * utilities.height));
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new WallMasterEastState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(enemy.Scale * utilities.width3), (int)(enemy.Scale * utilities.height));
        }
    }
}
