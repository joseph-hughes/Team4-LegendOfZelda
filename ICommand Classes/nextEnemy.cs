using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{

    public class nextEnemy : ICommand
    {

        public ILevel level;


        public nextEnemy(LegendOfZelda game)
        {
            this.level = game.level;
        }
        public void Execute()
        {
            level.NextEnemy();
        }
    }
}
