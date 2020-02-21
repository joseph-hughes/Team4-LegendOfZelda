using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class NonMovingNonAnimatedSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int XLocation { get; set; }
        private int YLocation { get; set; }

        // Constructor
        public NonMovingNonAnimatedSprite(Texture2D texture, Vector2 location)
        {
            Texture = texture;

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
            spriteBatch.Draw(Texture, new Rectangle(XLocation, YLocation, Texture.Width, Texture.Height), Color.White);
            spriteBatch.End();
        }
    }
}
