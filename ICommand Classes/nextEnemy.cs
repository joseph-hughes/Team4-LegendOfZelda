namespace Team4_LegendOfZelda
{

    public class nextEnemy : ICommand
    {

        public ILevel level;


        public nextEnemy(LegendOfZelda game)
        {
            this.level = game.level;
        }
        public void Execute()
        {
            level.NextEnemy();
        }
    }
}
