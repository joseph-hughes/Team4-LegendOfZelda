using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{

    public class PreviousEnemyCommand : ICommand
    {
        private Sprint2Room room;

        public PreviousEnemyCommand(Sprint2Room room)
        {
            this.room = room;
        }

        public void Execute()
        {
            room.PreviousEnemy();
        }
    }
}
