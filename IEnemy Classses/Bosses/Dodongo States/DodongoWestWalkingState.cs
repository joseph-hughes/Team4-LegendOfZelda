﻿using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States
{
    class DodongoWestWalkingState : IState
    {
        IEnemy enemy;
        private const int width = 28;
        private const int height = 16;

        public DodongoWestWalkingState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Sprite = EnemySpriteFactory.Instance.CreateDodongoWestWalkingSprite();
            this.enemy.Rectangle = new Rectangle((int)this.enemy.Position.X, (int)this.enemy.Position.Y, (int)(this.enemy.Scale * width), (int)(this.enemy.Scale * height));
        }

        public void North()
        {
            enemy.State = new DodongoNorthWalkingState(enemy);
        }

        public void East()
        {
            enemy.State = new DodongoEastWalkingState(enemy);
        }

        public void South()
        {
            enemy.State = new DodongoSouthWalkingState(enemy);
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            // TODO
        }

        public void BeDamaged()
        {
            enemy.State = new DodongoWestDamagedState(enemy);
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
            //enemy.Position = new Microsoft.Xna.Framework.Vector2(((int)enemy.Position.X - 1) % 800, enemy.Position.Y);
            enemy.Rectangle = new Rectangle((int)enemy.Position.X, (int)enemy.Position.Y, (int)(enemy.Scale * width), (int)(enemy.Scale * height));
        }
    }
}
