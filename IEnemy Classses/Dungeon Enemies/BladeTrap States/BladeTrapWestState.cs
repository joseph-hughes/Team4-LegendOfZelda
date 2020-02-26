﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.BladeTrap_States
{
    class BladeTrapWestState : IState
    {
        private IEnemy enemy;
        private static int MAX_DISPLACEMENT = 240, DELTA_DISPLACEMENT = 16;
        private int displacement;

        public BladeTrapWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            displacement = MAX_DISPLACEMENT;
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
            if (displacement > 0)
            {
                if (enemy.Position.X > DELTA_DISPLACEMENT)
                {
                    enemy.Position = new Vector2((int)enemy.Position.X - DELTA_DISPLACEMENT, enemy.Position.Y);
                }
                else
                {
                    enemy.Position = new Vector2(768 - (int)enemy.Position.X - DELTA_DISPLACEMENT, enemy.Position.Y);
                }
                displacement -= DELTA_DISPLACEMENT;
            }
            else
            {
                Idle();
            }
        }
    }
}
