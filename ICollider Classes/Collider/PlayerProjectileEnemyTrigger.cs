using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.ILevel_Classes;

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
