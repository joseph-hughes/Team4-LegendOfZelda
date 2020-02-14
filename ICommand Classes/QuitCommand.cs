using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda
{
    class QuitCommand : ICommand
    {
        public Game game { get; set; }

        public QuitCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Exit();
        }
    }
}
