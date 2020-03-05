namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IHUD
    {
        int HUDWidth { get; set; }
        int HUDHeight { get; set; }
        ISprite HUDSprite { get; set; }

        void Initialize(int hudWidth, int hudHeight);
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
