namespace Team4_LegendOfZelda
{
    public class QuitCommand : ICommand
    {
        private LegendOfZelda game;

        public QuitCommand(LegendOfZelda game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.Exit();
        }
    }
}
