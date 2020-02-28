using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ISprite_Classes
{
    class TextSprite : ISprite
    {
        private SpriteFont Font { get; set; }
        private string Text { get; set; }

        // Constructor
        public TextSprite(SpriteFont font, string text)
        {
            Font = font;
            Text = text;
        }

        public void Update()
        {
            // Nothing to update
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(Font, Text, new Vector2(destinationRectangle.X, destinationRectangle.Y), Color.Black);
            spriteBatch.End();
        }
    }
}
