using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{

    public class NextEnemyCommand : ICommand
    {
        private Sprint2Level level;

        public NextEnemyCommand(Sprint2Level level)
        {
            this.level = level;
        }

        public void Execute()
        {
            level.NextEnemy();
        }
    }
}
