using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class NonMovingAnimatedSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int XLocation { get; set; }
        private int YLocation { get; set; }
        private int Rows { get; set; }
        private int Columns { get; set; }
        private int TotalDelay { get; set; }
        private int delay;
        private int currentFrame;
        private int totalFrames;
        private int width;
        private int height;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;

        // Constructor
        public NonMovingAnimatedSprite(Texture2D texture, Vector2 location, int rows, int columns, int delayBetweenFrames)
        {
            Texture = texture;

            XLocation = (int)location.X;
            YLocation = (int)location.Y;

            Rows = rows;
            Columns = columns;

            TotalDelay = delayBetweenFrames;
            delay = 0;

            currentFrame = 0;
            totalFrames = Rows * Columns;

            width = Texture.Width / Columns;
            height = Texture.Height / Rows;
        }

        public void Update()
        {
            delay = (delay + 1) % TotalDelay;
            if (delay == 0)
            {
                currentFrame = (currentFrame + 1) % totalFrames;
            }

            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            sourceRectangle = new Rectangle(width * column, height * row, width, height);
            destinationRectangle = new Rectangle(XLocation, YLocation, width, height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
