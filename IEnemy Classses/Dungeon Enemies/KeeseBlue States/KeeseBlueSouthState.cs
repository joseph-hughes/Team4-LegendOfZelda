﻿using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.Utility_Classes;


namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies.KeeseBlue_States
{
    class KeeseBlueSouthState : IState
    {
        private IEnemy enemy;

        public KeeseBlueSouthState(IEnemy enemy)
        {
            this.enemy = enemy;
            this.enemy.Velocity.Magnitude = UtilityClass.Instance.KeeseBlue_SPEED();
            this.enemy.Velocity.Direction = Vector.Orientation.South;
        }

        public void North()
        {
            enemy.State = new KeeseBlueNorthState(enemy);
        }

        public void East()
        {
            enemy.State = new KeeseBlueEastState(enemy);
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            enemy.State = new KeeseBlueWestState(enemy);
        }

        public void Idle()
        {
            enemy.State = new KeeseBlueIdleState(enemy);
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
            enemy.DestinationRectangle = new Rectangle(enemy.DestinationRectangle.X, enemy.DestinationRectangle.Y + enemy.Velocity.Magnitude, enemy.DestinationRectangle.Width, enemy.DestinationRectangle.Height);
        }
    }
}
