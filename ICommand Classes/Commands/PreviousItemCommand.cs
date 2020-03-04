using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{

    public class PreviousItemCommand : ICommand
    {
        private Sprint2Room room;

        public PreviousItemCommand(Sprint2Room room)
        {
            this.room = room;
        }

        public void Execute()
        {
            room.PreviousItem();
        }
    }
}