namespace Team4_LegendOfZelda
{
    public class LinkChangeItemCommand : ICommand
    {
        private IPlayer player;

        public LinkChangeItemCommand(IPlayer player)
        {
            this.player = player;
        }
        public void Execute()
        {
            // TODO
        }
    }
}
