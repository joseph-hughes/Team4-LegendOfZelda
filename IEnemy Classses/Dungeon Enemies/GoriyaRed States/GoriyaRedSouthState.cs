﻿using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedSouthState : IState
    {
        IEnemy enemy;
        private UtilityClass utilities = new UtilityClass();
      

        public GoriyaRedSouthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedSouthSprite();
            this.enemy.DestinationRectangle = new Rectangle((int)this.enemy.DestinationRectangle.X, (int)this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * utilities.width2), (int)(this.enemy.Scale * utilities.height));
        }

        public void North()
        {
            enemy.State = new GoriyaRedNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new GoriyaRedEastState(enemy);
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            enemy.State = new GoriyaRedWestState(enemy);
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
            enemy.State = new GoriyaRedSouthAttackState(enemy);
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, ((int)enemy.DestinationRectangle.Y + 1) % 600, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
            enemy.DestinationRectangle = new Rectangle((int)enemy.DestinationRectangle.X, (int)enemy.DestinationRectangle.Y, (int)(enemy.Scale * utilities.width2), (int)(enemy.Scale * utilities.height));
        }
    }
}
