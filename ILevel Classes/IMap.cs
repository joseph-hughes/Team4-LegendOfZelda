namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IMap
    {
        Microsoft.Xna.Framework.Rectangle DestinationRectangle { get; set; }
        ISprite MapSprite { get; set; }

        void Initialize(int mapXPosition, int mapYPosition, int mapWidth, int mapHeight);
        void North();
        void East();
        void South();
        void West();
        void Other();
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
