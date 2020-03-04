using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ISprite_Classes
{
    class TextSprite : ISprite
    {
        public Rectangle SourceRectangle { get; set; }
        private SpriteFont font;
        private string text;

        // Constructor
        public TextSprite(SpriteFont font, string text)
        {
            this.font = font;
            this.text = text;
        }

        public void Update()
        {
            // Nothing to update
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, text, new Vector2(destinationRectangle.X, destinationRectangle.Y), Color.Black);
            spriteBatch.End();
        }
    }
}
