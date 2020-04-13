﻿using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseRed_States
{
    class KeeseRedNorthState : IState
    {
        private IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
      
        private int displacement;

        public KeeseRedNorthState(IEnemy enemy)
        {
            this.enemy = enemy;
            displacement = utilities.MAX_DISPLACEMENT2;
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
            enemy.State = new KeeseRedIdleState(enemy);
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
            //enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, ((int)enemy.DestinationRectangle.Y - 2) % 600);
            if (displacement > 0)
            {
                if (enemy.DestinationRectangle.Y > utilities.DELTA_DISPLACEMENT2)
                {
                    enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y - utilities.DELTA_DISPLACEMENT2, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                }
                else
                {
                    enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, 528 - enemy.DestinationRectangle.Y - utilities.DELTA_DISPLACEMENT2, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
                }
                displacement -= utilities.DELTA_DISPLACEMENT2;
            }
            else
            {
                Idle();
            }
        }
    }
}
