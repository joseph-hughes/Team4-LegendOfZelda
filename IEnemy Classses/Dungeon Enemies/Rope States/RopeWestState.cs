﻿using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.Rope_States
{
    class RopeWestState : IState
    {
        IEnemy enemy;
        UtilityClass utilities = new UtilityClass();


        public RopeWestState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateRopeWestSprite();
            this.enemy.DestinationRectangle = new Rectangle((int)this.enemy.DestinationRectangle.X, (int)this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * utilities.width3), (int)(this.enemy.Scale * utilities.height2));
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            enemy.State = new RopeEastState(enemy);
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
            enemy.DestinationRectangle = new Rectangle((int)enemy.DestinationRectangle.X, (int)enemy.DestinationRectangle.Y, (int)(enemy.Scale * utilities.width3), (int)(enemy.Scale * utilities.height2));
        }
    }
}
