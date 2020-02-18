namespace Team4_LegendOfZelda
{
    public class LinkAttackCommand : ICommand
    {
        private IPlayer player;

        public LinkAttackCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Attack();
        }
    }
}