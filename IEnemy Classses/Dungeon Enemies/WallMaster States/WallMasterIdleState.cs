using Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.WallMaster_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.WallMaster_States
{
    class WallMasterIdleState : IState
    {
        IEnemy enemy;

        public WallMasterIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void North()
        {
            enemy.State = new WallMasterNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new WallMasterEastState(enemy);
        }

        public void South()
        {
            enemy.State = new WallMasterSouthState(enemy);
        }

        public void West()
        {
            enemy.State = new WallMasterWestState(enemy);
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
            // Do nothing
        }
    }
}
