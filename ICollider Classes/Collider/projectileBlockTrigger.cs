namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class ProjectileBlockTrigger : ITrigger
    {
        private ILevel level;
        private IProjectile projectile;
        public ProjectileBlockTrigger(IProjectile Projectile, ILevel Level)
        {
            level = Level;
            projectile = Projectile;
        }
        public void Execute()
        {
            if (level.PlayerProjectileList.Contains(projectile))
            {
                level.PlayerProjectileList.Remove(projectile);
            }
            if (level.EnemyProjectileList.Contains(projectile))
            {
                level.EnemyProjectileList.Remove(projectile);
            }

        }
    }
}
