namespace Sprint0
{
    public class QuitCommand : ICommand
    {
        public SpritesGame ThisGame { get; set; }
        public QuitCommand(SpritesGame thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute ()
        {
            ThisGame.Exit();
        }
    }
}
