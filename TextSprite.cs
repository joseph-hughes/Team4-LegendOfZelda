using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class TextSprite : ISprite
    {
        private SpriteFont Font { get; set; }
        private string Text { get; set; }
        private int XLocation { get; set; }
        private int YLocation { get; set; }

        // Constructor
        public TextSprite(SpriteFont font, string text, Vector2 location)
        {
            Font = font;
            Text = text;

            XLocation = (int)location.X;
            YLocation = (int)location.Y;
        }

        public void Update()
        {
            // Nothing to update
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(Font, Text, new Vector2(XLocation, YLocation), Color.Black);
            spriteBatch.End();
        }
    }
}
