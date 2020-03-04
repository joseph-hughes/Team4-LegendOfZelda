namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerProjectileEnemyTrigger : ITrigger
    {
        private ILevel level;
        private IEnemy enemy;
        private IProjectile projectile;

        public PlayerProjectileEnemyTrigger(IProjectile Projectile, IEnemy Enemy, ILevel Level)
        {
            level = Level;
            projectile = Projectile;
            enemy = Enemy;


        }
        public void Execute()
        {
            level.PlayerProjectileList.Remove(projectile);
            enemy.BeDamaged();
        }
    }
}
