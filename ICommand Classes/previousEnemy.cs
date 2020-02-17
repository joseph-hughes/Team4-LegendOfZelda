using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{

    public class previousEnemy : ICommand
    {
        public LegendOfZelda game { get; set; }


        public previousEnemy(LegendOfZelda game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.level.previousEnemy();
        }
    }
}