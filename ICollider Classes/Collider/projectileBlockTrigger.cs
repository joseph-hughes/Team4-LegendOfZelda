using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class ProjectileBlockTrigger : ITrigger
    {
        private IRoom currentRoom;
        private IProjectile projectile;
        public ProjectileBlockTrigger(IProjectile projectile, IRoom room)
        {
            this.currentRoom = room;
            this.projectile = projectile;
        }
        public void Execute()
        {
            if (currentRoom.PlayerProjectiles.Contains(projectile))
            {
                currentRoom.PlayerProjectiles.Remove(projectile);
            }
            if (currentRoom.EnemyProjectiles.Contains(projectile))
            {
                currentRoom.EnemyProjectiles.Remove(projectile);
            }

        }
    }
}
