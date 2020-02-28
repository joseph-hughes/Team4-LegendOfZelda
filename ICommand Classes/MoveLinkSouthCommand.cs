namespace Team4_LegendOfZelda
{
    public class MoveLinkSouthCommand : ICommand
    {
        private IPlayer player;

        public MoveLinkSouthCommand(IPlayer player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.South();
        }
    }
}