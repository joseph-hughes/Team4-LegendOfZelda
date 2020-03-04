﻿using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class EnemyBlockTrigger : ITrigger
    {
        private IEnemy enemy;
        private IBlock block;

        public EnemyBlockTrigger(IEnemy Enemy, IBlock Block)
        {
            enemy = Enemy;
            block = Block;
        }
        public void Execute()
        {
            int direction;

            float dx = enemy.Rectangle.X - block.Rectangle.X;
            float dy = enemy.Rectangle.Y - block.Rectangle.Y;

            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dy > 0)
                {
                    direction = 0;
                }
                else
                {
                    direction = 2;
                }
            }
            //left right collision
            else
            {
                if (dx > 0)
                {
                    direction = 3;
                }
                else
                {
                    direction = 1;
                }
            }

 //           if (enemy.Direction == direction)
            {
//                enemy.Velocity = 0;
            }

        }
    }
}
