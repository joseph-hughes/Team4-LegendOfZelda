namespace Team4_LegendOfZelda
{
    public class moveLinkUp : ICommand
    {

        public IPlayer player { get; set; }

        public moveLinkUp(LegendOfZelda game)
        {
            this.player = game.player;
        }
        public void Execute()
        {
            player.North();
        }
    }
}