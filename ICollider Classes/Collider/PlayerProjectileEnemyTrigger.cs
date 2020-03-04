using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerProjectileEnemyTrigger : ITrigger
    {
        private IRoom room;
        private IEnemy enemy;
        private IProjectile projectile;

        public PlayerProjectileEnemyTrigger(IProjectile projectile, IEnemy enemy, IRoom room)
        {
            this.room = room;
            this.projectile = projectile;
            this.enemy = enemy;


        }
        public void Execute()
        {
            room.PlayerProjectiles.Remove(projectile);
            enemy.BeDamaged();
        }
    }
}
