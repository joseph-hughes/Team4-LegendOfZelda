using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{
    public class moveLinkDown : ICommand
    {
        public Link player { get; set; }
        
        public moveLinkDown(LegendOfZelda game)
        {
            player = game.player;
        }
        public void Execute()
        {
            player.South();
        }
    }
}