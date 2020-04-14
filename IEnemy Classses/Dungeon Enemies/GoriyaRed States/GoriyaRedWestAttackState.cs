﻿using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.GoriyaRed_States
{
    class GoriyaRedWestAttackState : IState
    {
        IEnemy enemy;
        // Projectile item
        int count;

        public GoriyaRedWestAttackState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateGoriyaRedWestSprite();
            this.enemy.DestinationRectangle = new Rectangle(this.enemy.DestinationRectangle.X, this.enemy.DestinationRectangle.Y, (int)(this.enemy.Scale * UtilityClass.Instance.GoriyaRed_WIDTH()), (int)(this.enemy.Scale * UtilityClass.Instance.GoriyaRed_HEIGHT()));
            this.enemy.Velocity.Magnitude = 0;
            this.enemy.Velocity.Direction = Vector.Orientation.West;
            // Create boomerang
            count = UtilityClass.Instance.GoriyaRed_MAX_COUNTS();
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
            count--;
            if (count <= 0)
            {
                enemy.State = new GoriyaRedWestWalkingState(enemy);
            }
        }
    }
}
