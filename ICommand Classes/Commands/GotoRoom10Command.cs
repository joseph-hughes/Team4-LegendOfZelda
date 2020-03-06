namespace Team4_LegendOfZelda
{
    class GotoRoom10Command : ICommand
    {
        private LegendOfZelda game;
        private const int COLUMN_NUM = 2;
        private const int ROW_NUM = 2;

        public GotoRoom10Command(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.level.Map.MapSprite.SourceRectangle = new Microsoft.Xna.Framework.Rectangle(
                COLUMN_NUM * game.level.Map.MapSprite.SourceRectangle.Width,
                ROW_NUM * game.level.Map.MapSprite.SourceRectangle.Height,
                game.level.Map.MapSprite.SourceRectangle.Width,
                game.level.Map.MapSprite.SourceRectangle.Height
                );
            game.level.CurrentRoom = game.level.Rooms[9];
        }
    }
}
