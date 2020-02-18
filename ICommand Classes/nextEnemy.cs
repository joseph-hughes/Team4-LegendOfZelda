using System;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{

    public class nextEnemy : ICommand
    {
 
        private Sprint2Level level;

        public nextEnemy(Sprint2Level level)
        {
            this.level = level;
        }
        public void Execute()
        {
            level.NextEnemy();
        }
    }
}
