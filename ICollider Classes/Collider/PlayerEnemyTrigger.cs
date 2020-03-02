using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerEnemyTrigger : ITrigger
    {
        private ILevel level;
        private IPlayer player;
        private IEnemy enemy;
        private int direction; 
        public PlayerEnemyTrigger(IPlayer Player, IEnemy Enemy, ILevel Level)
        {
            level = Level;
            player = Player;
            enemy = Enemy;

            float dx = player.Rectangle.X - Enemy.Rectangle.X;
            float dy = player.Rectangle.Y - Enemy.Rectangle.Y;

            //top bottom collision
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
        }
        public void Execute()
        {
            if (player.isAttacking&& player.Direction == direction)
            {
                enemy.State.BeDamaged();
            }
            else
            {
                player.BeDamaged();
            }
        }
    }
}
