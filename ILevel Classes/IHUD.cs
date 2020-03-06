namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IHUD
    {
        ILevel Level { get; set; }
        Microsoft.Xna.Framework.Rectangle DestinationRectangle { get; set; }
        ISprite HUDSprite { get; set; }
        ISprite LevelNumSprite { get; set; }

        void Initialize(int hudXPosition, int hudYPosition, int hudWidth, int hudHeight);
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
