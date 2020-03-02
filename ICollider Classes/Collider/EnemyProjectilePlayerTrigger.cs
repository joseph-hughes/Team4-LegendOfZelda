using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class EnemyProjectilePlayerTrigger : ITrigger
    {
        private ILevel level;
        private Link player;
        private IProjectile projectile;

        public EnemyProjectilePlayerTrigger(IProjectile Projectile, IPlayer Player, ILevel Level)
        {
            level = Level;
            projectile = Projectile;
            player = (Link)Player;
        }
        public void Execute()
        {
            level.EnemyProjectileList.Remove(projectile);

            float dx = projectile.Rectangle.X - player.Rectangle.X;
            float dy = projectile.Rectangle.Y - player.Rectangle.Y;

            //top bottom collision
            if (System.Math.Abs(dx) < System.Math.Abs(dy))
            {
                if (dy > 0)
                {
                    player.State = new LinkKnockbackSouthState(player, Link.knockback_timer);
                }
                else
                {
                    player.State = new LinkKnockbackNorthState(player, Link.knockback_timer);
                }
            }
            //left right collision
            else
            {
                if (dx > 0)
                {
                    player.State = new LinkKnockbackEastState(player, Link.knockback_timer);
                }
                else
                {
                    player.State = new LinkKnockbackWestState(player, Link.knockback_timer);
                }
            }
        }
    }
}
