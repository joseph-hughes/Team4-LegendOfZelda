using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{
    public class resetGame : ICommand
    {
        public LegendOfZelda ThisGame { get; set; }
        public resetGame(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            ThisGame = new LegendOfZelda();
        }
    }
}
