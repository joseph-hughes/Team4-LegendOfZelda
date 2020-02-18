namespace Team4_LegendOfZelda
{
    public class moveLinkRight : ICommand
    {
        public IPlayer player { get; set; }
        public LegendOfZelda ThisGame { get; set; }
        public moveLinkRight(LegendOfZelda thisGame)
        {
            player = thisGame.player;
        }
        public void Execute()
        {
            player.East();
        }
    }
}
