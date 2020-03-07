using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerProjectileEnemyTrigger : ITrigger
    {
        private IRoom currentRoom;
        private IEnemy enemy;
        private IProjectile projectile;

        public PlayerProjectileEnemyTrigger(IProjectile projectile, IEnemy enemy, IRoom room)
        {
            this.currentRoom = room;
            this.projectile = projectile;
            this.enemy = enemy;


        }
        public void Execute()
        {
            currentRoom.PlayerProjectiles.Remove(projectile);
            enemy.State.BeDamaged();
        }
    }
}
