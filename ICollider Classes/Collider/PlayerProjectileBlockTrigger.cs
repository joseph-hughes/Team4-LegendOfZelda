using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerProjectileBlockTrigger : ITrigger
    {
        private ILevel level;
        private IProjectile playerProjectile;
        public PlayerProjectileBlockTrigger(IProjectile PlayerProjectile, ILevel Level)
        {
            this.level = Level;
            this.playerProjectile = PlayerProjectile;
        }
        public void Execute()
        {
            level.PlayerProjectileList.Remove(playerProjectile);
        }
    }
}
