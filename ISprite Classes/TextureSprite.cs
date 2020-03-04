﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ISprite_Classes
{
    class TextureSprite : ISprite
    {
        private Texture2D texture;
        private int rows;
        private int columns;
        private int totalDelay;
        private int delay;
        private int currentFrame;
        private int totalFrames;
        private int width;
        private int height;
        private float scale;
        private Rectangle sourceRectangle;
        private bool animated;

        // Constructor
        public TextureSprite(Texture2D texture, float scale)
        {
            this.texture = texture;
            animated = false;
            width = texture.Width;
            height = texture.Height;
            this.scale = scale;
            sourceRectangle = new Rectangle(0, 0, width, height);
        }

        public TextureSprite(Texture2D texture, float scale, int sheetRows, int sheetColumns, int delayBetweenFrames)
        {
            this.texture = texture;

            rows = sheetRows;
            columns = sheetColumns;

            totalDelay = delayBetweenFrames;
            delay = 0;

            currentFrame = 0;
            totalFrames = rows * columns;

            width = texture.Width / columns;
            height = texture.Height / rows;
            this.scale = scale;

            sourceRectangle = new Rectangle(0, 0, width, height);

            animated = true;
        }

        public void Update()
        {
            if (animated)
            {
                delay = (delay + 1) % totalDelay;
                if (delay == 0)
                {
                    currentFrame = (currentFrame + 1) % totalFrames;

                    int row = (int)((float)currentFrame / (float)columns);
                    int column = currentFrame % columns;

                    sourceRectangle = new Rectangle(width * column, height * row, width, height);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(width * scale), (int)(height * scale));
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}