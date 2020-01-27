using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class MovingNonAnimatedSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int XLocation { get; set; }
        private int YLocation { get; set; }
        private int Speed { get; set; }

        // Constructor
        public MovingNonAnimatedSprite(Texture2D texture, Vector2 location, int movementSpeed)
        {
            Texture = texture;

            XLocation = (int)location.X;
            YLocation = (int)location.Y;

            Speed = movementSpeed;
        }

        public void Update()
        {
            YLocation -= Speed;
            if (YLocation < -Texture.Height)
            {
                YLocation = 480;
            }
            else if (YLocation > 480)
            {
                YLocation = -Texture.Height;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, new Rectangle(XLocation, YLocation, Texture.Width, Texture.Height), Color.White);
            spriteBatch.End();
        }
    }
}
