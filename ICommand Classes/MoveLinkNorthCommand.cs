namespace Team4_LegendOfZelda
{
    public class MoveLinkNorthCommand : ICommand
    {
        private IPlayer player;

        public MoveLinkNorthCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.North();
        }
    }
}