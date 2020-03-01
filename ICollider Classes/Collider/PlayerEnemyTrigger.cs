using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.ICollider_Classes.Collider
{
    class PlayerEnemyTrigger : ITrigger
    {
        private ILevel level;
        private IPlayer player;
        private IEnemy enemy;
        private int direction; 
        public PlayerEnemyTrigger(IPlayer Player, IEnemy Enemy, ILevel Level, int Direction)
        {
            level = Level;
            player = Player;
            enemy = Enemy;
            direction = Direction;


        }
        public void Execute()
        {
            if (player.attackDirection == direction)
            {
                enemy.State.BeDamaged();
            }
            else
            {
                if (!player.isDamaged)
                {
                    player.State.BeDamaged();
                }
            }
        }
    }
}
