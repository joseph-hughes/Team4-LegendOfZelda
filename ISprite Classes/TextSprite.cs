using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public class TextSprite : ISprite
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

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(Font, Text, location, Color.Black);
            spriteBatch.End();
        }
    }
}
