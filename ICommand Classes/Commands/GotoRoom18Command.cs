namespace Team4_LegendOfZelda
{
    class GotoRoom18Command : ICommand
    {
        private LegendOfZelda game;
        private const int COLUMN_NUM = 2;
        private const int ROW_NUM = 0;
        private int width = 0;
        private int height = 0;

        public GotoRoom18Command(LegendOfZelda game)
        {
            this.game = game;
            width = game.level.Map.MapSprite.SourceRectangle.Width;
            height = game.level.Map.MapSprite.SourceRectangle.Height;
        }

        public void Execute()
        {
            game.level.Map.MapSprite.SourceRectangle = new Microsoft.Xna.Framework.Rectangle(
                COLUMN_NUM * width, ROW_NUM * height, width, height);
            game.gameState.RoomChange(game.level.Rooms[17]);
            game.level.CurrentRoom = game.level.Rooms[17];
        }
    }
}
