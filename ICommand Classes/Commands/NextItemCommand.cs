using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{

    public class NextItemCommand : ICommand
    {
        private Sprint2Room room;

        public NextItemCommand(Sprint2Room room)
        {
            this.room = room;
        }

        public void Execute()
        {
            room.NextItem();
        }
    }
}
