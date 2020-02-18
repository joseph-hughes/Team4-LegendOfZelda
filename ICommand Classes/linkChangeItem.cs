namespace Team4_LegendOfZelda
{
    public class linkChangeItem : ICommand
    {
        public LegendOfZelda ThisGame { get; set; }
        public linkChangeItem(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {

        }
    }
}
