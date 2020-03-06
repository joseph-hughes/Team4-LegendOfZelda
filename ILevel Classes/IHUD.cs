﻿namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IHUD
    {
        Microsoft.Xna.Framework.Rectangle DestinationRectangle { get; set; }
        ISprite HUDSprite { get; set; }
        ILevel Level { get; set; }

        void Initialize(int hudXPosition, int hudYPosition, int hudWidth, int hudHeight);
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
