using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class ProjectileBlockTrigger : ITrigger
    {
        private IRoom room;
        private IProjectile projectile;
        public ProjectileBlockTrigger(IProjectile projectile, IRoom room)
        {
            this.room = room;
            this.projectile = projectile;
        }
        public void Execute()
        {
            if (room.PlayerProjectiles.Contains(projectile))
            {
                room.PlayerProjectiles.Remove(projectile);
            }
            if (room.EnemyProjectiles.Contains(projectile))
            {
                room.EnemyProjectiles.Remove(projectile);
            }

        }
    }
}
