namespace Team4_LegendOfZelda
{

    public class MoveLinkWestCommand : ICommand
    {
        private IPlayer player;

        public MoveLinkWestCommand(IPlayer player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.West();
        }
    }
}
