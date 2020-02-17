using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{

    public class nextEnemy : ICommand
    {
 
        private Sprint2Level level = new Sprint2Level();


        public nextEnemy(Sprint2Level level)
        {
            this.level = level;
        }
        public void Execute()
        {
            game.level.NextEnemy();
        }
    }
}
