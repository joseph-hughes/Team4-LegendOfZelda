namespace Team4_LegendOfZelda
{
    public class MoveLinkEastCommand : ICommand
    {
        private IPlayer player;

        public MoveLinkEastCommand(IPlayer player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.East();
        }
    }
}
