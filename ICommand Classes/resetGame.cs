namespace Team4_LegendOfZelda
{
    public class resetGame : ICommand
    {
        public LegendOfZelda ThisGame { get; set; }
        public resetGame(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            ThisGame = new LegendOfZelda();
        }
    }
}
