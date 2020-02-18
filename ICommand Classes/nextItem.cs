namespace Team4_LegendOfZelda
{

    public class nextItem : ICommand
    {

        public ILevel level;


        public nextItem(LegendOfZelda game)
        {
            this.level = game.level;
        }
        public void Execute()
        {
            level.NextItem();
        }
    }
}
