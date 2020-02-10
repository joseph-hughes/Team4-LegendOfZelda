using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public class Sprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int Rows { get; set; }
        private int Columns { get; set; }
        private int TotalDelay { get; set; }
        private int delay;
        private int currentFrame;
        private int totalFrames;
        private int width;
        private int height;
        private Rectangle sourceRectangle;
        private bool animated;

        // Constructor
        public Sprite(Texture2D texture)
        {
            Texture = texture;
            animated = false;
            sourceRectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
        }

        public Sprite(Texture2D texture, int rows, int columns, int delayBetweenFrames)
        {
            Texture = texture;

            Rows = rows;
            Columns = columns;

            TotalDelay = delayBetweenFrames;
            delay = 0;

            currentFrame = 0;
            totalFrames = Rows * Columns;

            width = Texture.Width / Columns;
            height = Texture.Height / Rows;

            sourceRectangle = new Rectangle(0, 0, width, height);

            animated = true;
        }

        public void Update()
        {
            if (animated)
            {
                delay = (delay + 1) % TotalDelay;
                if (delay == 0)
                {
                    currentFrame = (currentFrame + 1) % totalFrames;

                    int row = (int)((float)currentFrame / (float)Columns);
                    int column = currentFrame % Columns;

                    sourceRectangle = new Rectangle(width * column, height * row, width, height);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
