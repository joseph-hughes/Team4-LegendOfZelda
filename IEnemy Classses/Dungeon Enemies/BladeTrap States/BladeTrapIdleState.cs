
﻿using Team4_LegendOfZelda.Utility_Classes;
namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.BladeTrap_States
    
{
    class BladeTrapIdleState : IState
    {
        IEnemy enemy;

        public BladeTrapIdleState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = 0;
        }

        public void North()
        {
            enemy.State = new BladeTrapNorthAttackState(enemy);
        }

        public void East()
        {
            enemy.State = new BladeTrapEastAttackState(enemy);
        }

        public void South()
        {
            enemy.State = new BladeTrapSouthAttackState(enemy);
        }

        public void West()
        {
            enemy.State = new BladeTrapWestAttackState(enemy);
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
            // Do nothing
        }
    }
}
