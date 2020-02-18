namespace Team4_LegendOfZelda
{
    public class linkAttack : ICommand
    {
        public IPlayer player { get; set; }
        public linkAttack(LegendOfZelda game)
        {
            this.player = game.player;
        }
        public void Execute()
        {
            player.Attack();
        }
    }
}