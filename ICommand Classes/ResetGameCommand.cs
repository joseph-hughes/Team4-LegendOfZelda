namespace Team4_LegendOfZelda
{
    public class ResetGameCommand : ICommand
    {
        private LegendOfZelda game;

        public ResetGameCommand(LegendOfZelda game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game = new LegendOfZelda();
        }
    }
}
