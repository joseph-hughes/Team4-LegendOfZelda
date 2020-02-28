using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{

    public class PreviousEnemyCommand : ICommand
    {
        private Sprint2Level level = new Sprint2Level();

        public PreviousEnemyCommand(Sprint2Level level)
        {
            this.level = level;
        }

        public void Execute()
        {
            level.PreviousEnemy();
        }
    }
}
