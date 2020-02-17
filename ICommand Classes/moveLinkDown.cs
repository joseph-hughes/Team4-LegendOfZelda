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
        public LegendOfZelda ThisGame { get; set; }
        public moveLinkDown(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            player.South();
        }
    }
}