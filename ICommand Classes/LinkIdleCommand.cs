namespace Team4_LegendOfZelda
{
    public class LinkIdleCommand : ICommand
    {
        private IPlayer player;
        
        public LinkIdleCommand(IPlayer player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.Idle();
        }
    }
}