using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{

    public class previousEnemy : ICommand
    {

        public ILevel level;


        public previousEnemy(LegendOfZelda game)
        {
            this.level = game.level;
        }
        public void Execute()
        {
            level.PreviousEnemy();
        }
    }
}
