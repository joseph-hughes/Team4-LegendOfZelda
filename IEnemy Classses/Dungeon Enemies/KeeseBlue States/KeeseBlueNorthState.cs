﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseBlue_States
{
    class KeeseBlueNorthState : IState
    {
        private IEnemy enemy;
        private static int MAX_DISPLACEMENT = 48, DELTA_DISPLACEMENT = 2;
        private int displacement;

        public KeeseBlueNorthState(IEnemy enemy)
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
            enemy.State = new KeeseBlueIdleState(enemy);
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
                //enemy.Position = new Vector2(enemy.Position.X, ((int)enemy.Position.Y - 2) % 600);
                if (enemy.Position.Y > DELTA_DISPLACEMENT)
                {
                    enemy.Position = new Rectangle(enemy.Position.X, (int)enemy.Position.Y - DELTA_DISPLACEMENT, enemy.Position.Width, enemy.Position.Height);
                }
                else
                {
                    enemy.Position = new Rectangle(enemy.Position.X, 528 - (int)enemy.Position.Y - DELTA_DISPLACEMENT, enemy.Position.Width, enemy.Position.Height);
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
