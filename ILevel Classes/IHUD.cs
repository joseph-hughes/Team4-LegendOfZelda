namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IHUD
    {
        ILevel Level { get; set; }
        ISprite HUDSprite { get; set; }
        Microsoft.Xna.Framework.Rectangle HUDDestinationRectangle { get; set; }
        ISprite MinimapSprite { get; set; }
        Microsoft.Xna.Framework.Rectangle MinimapDestinationRectangle { get; set; }
        System.Collections.Generic.List<ISprite> HeartSprites { get; set; }
        System.Collections.Generic.List<int> HeartValues { get; set; }
        System.Collections.Generic.List<Microsoft.Xna.Framework.Rectangle> HeartDestinationRectangles { get; set; }
        int CurrentPlayerHitPoints { get; set; }

        void Initialize(int hudXPosition, int hudYPosition, int hudWidth, int hudHeight);
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
