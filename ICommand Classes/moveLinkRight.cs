using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{
    public class moveLinkRight : ICommand
    {
        public Link player { get; set; }
        public LegendOfZelda ThisGame { get; set; }
        public moveLinkRight(LegendOfZelda thisGame)
        {
            player = thisGame.player;
        }
        public void Execute()
        {
            player.East();
        }
    }
}
