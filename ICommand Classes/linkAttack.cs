using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{
    public class linkAttack : ICommand
    {
        public Link player { get; set; }
        public linkAttack(LegendOfZelda game)
        {
            this.player = game.player;
        }
        public void Execute()
        {
            player.Attack();
        }
    }
}