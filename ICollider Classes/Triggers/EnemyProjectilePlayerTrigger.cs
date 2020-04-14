using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class EnemyProjectilePlayerTrigger : ITrigger
    {
        private IRoom currentRoom;
        private Link player;
        private IProjectile projectile;

        public EnemyProjectilePlayerTrigger(IProjectile projectile, IPlayer player, IRoom room)
        {
            this.currentRoom = room;
            this.projectile = projectile;
            this.player = (Link)player;
        }
        public void Execute()
        {
            currentRoom.EnemyProjectiles.Remove(projectile);

            if (!player.IsDamaged)
            {

                float dx = projectile.DestinationRectangle.X - player.DestinationRectangle.X;
                float dy = projectile.DestinationRectangle.Y - player.DestinationRectangle.Y;

                //top bottom collision
                if (System.Math.Abs(dx) < System.Math.Abs(dy))
                {
                    if (dy > 0)
                    {
                        player.South();
                        player.BeDamaged();
                    }
                    else
                    {
                        player.North();
                        player.BeDamaged();
                    }
                }
                //left right collision
                else
                {
                    if (dx > 0)
                    {
                        player.East();
                        player.BeDamaged();
                    }
                    else
                    {
                        player.West();
                        player.BeDamaged();
                    }
                }
            }


        }
    }
}
