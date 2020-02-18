namespace Team4_LegendOfZelda
{
    public class takeDamage : ICommand
    {
        public Link player { get; set; }
        public LegendOfZelda ThisGame { get; set; }
        public takeDamage(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            player.BeDamaged();
        }
    }
}
