namespace Team4_LegendOfZelda
{
    public class moveLinkDown : ICommand
    {
        public IPlayer player { get; set; }

        public moveLinkDown(LegendOfZelda game)
        {
            player = game.player;
        }
        public void Execute()
        {
            player.South();
        }
    }
}