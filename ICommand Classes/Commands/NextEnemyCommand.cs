using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{

    public class NextEnemyCommand : ICommand
    {
        private Sprint2Room room;

        public NextEnemyCommand(Sprint2Room room)
        {
            this.room = room;
        }

        public void Execute()
        {
            room.NextEnemy();
        }
    }
}
