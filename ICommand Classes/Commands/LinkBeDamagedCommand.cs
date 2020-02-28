namespace Team4_LegendOfZelda
{
    public class LinkBeDamagedCommand : ICommand
    {
        private IPlayer player;

        public LinkBeDamagedCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.BeDamaged();
        }
    }
}
