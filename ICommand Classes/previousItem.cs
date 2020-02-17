using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{

    public class previousItem : ICommand
    {
        public LegendOfZelda game { get; set; }


        public previousItem(LegendOfZelda thisGame)
        {
            this.game = thisGame;
        }
        public void Execute()
        {
            game.level.previousItem();
        }
    }
}