using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{

    public class previousItem : ICommand
    {
        public ILevel level;


        public previousItem(LegendOfZelda game)
        {
            this.level = game.level;
        }
        public void Execute()
        {
            level.PreviousItem();
        }
    }
}