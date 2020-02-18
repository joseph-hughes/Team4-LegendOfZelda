namespace Team4_LegendOfZelda
{
    public class QuitCommand : ICommand
    {
        public LegendOfZelda ThisGame { get; set; }
        public QuitCommand(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            ThisGame.Exit();
        }
    }
}
