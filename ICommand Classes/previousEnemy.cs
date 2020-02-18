namespace Team4_LegendOfZelda
{

    public class previousEnemy : ICommand
    {

        public ILevel level;


        public previousEnemy(LegendOfZelda game)
        {
            this.level = game.level;
        }
        public void Execute()
        {
            level.PreviousEnemy();
        }
    }
}
