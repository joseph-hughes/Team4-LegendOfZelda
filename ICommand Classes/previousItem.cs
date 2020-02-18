namespace Team4_LegendOfZelda
{

    public class previousItem : ICommand
    {
        public ILevel level;


        public previousItem(LegendOfZelda game)
        {
            this.level = game.level;
        }
        public void Execute()
        {
            level.PreviousItem();
        }
    }
}