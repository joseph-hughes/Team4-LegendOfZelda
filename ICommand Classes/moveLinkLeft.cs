using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{

    public class moveLinkLeft : ICommand
    {
        public IPlayer player { get; set; }

        
        public moveLinkLeft(LegendOfZelda thisGame)
        {
            player = thisGame.player;
        }
        public void Execute()
        {
            player.West();
        }
    }
}
