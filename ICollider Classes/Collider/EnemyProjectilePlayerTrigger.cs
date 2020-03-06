using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class EnemyProjectilePlayerTrigger : ITrigger
    {
        private IRoom room;
        private Link player;
        private IProjectile projectile;

        public EnemyProjectilePlayerTrigger(IProjectile projectile, IPlayer player, IRoom room)
        {
            this.room = room;
            this.projectile = projectile;
            this.player = (Link)player;
        }
        public void Execute()
        {
            room.EnemyProjectiles.Remove(projectile);

            if (!player.isDamaged)
            {

                float dx = projectile.DestinationRectangle.X - player.DestinationRectangle.X;
                float dy = projectile.DestinationRectangle.Y - player.DestinationRectangle.Y;

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
}
