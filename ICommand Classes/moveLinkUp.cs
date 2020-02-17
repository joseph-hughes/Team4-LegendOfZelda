using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{
    public class moveLinkUp : ICommand
    {
       
        public IPlayer player { get; set; }
        
        public moveLinkUp(LegendOfZelda game)
        {
            this.player = game.player;
        }
        public void Execute()
        {
            player.North();
        }
    }
}