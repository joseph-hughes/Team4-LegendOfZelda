using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ItemObject
{
    class CreateAnimatedItemSprite : MyItem
    {
        Texture2D image;
        Vector2 position;
        Rectangle sourceRectangle;
        Rectangle destinationRectangle;
        int width;
        int height;
        int currentFrame;
        int totalFrame;
        int delay;
        const int totalDelay = 5;

        public CreateAnimatedItemSprite(Texture2D texture, Vector2 location, int frame, int spriteWidth, int spriteHeight)
        {
            image = texture;
            width = spriteWidth;
            height = spriteHeight;
            totalFrame = frame - 1;
            position = location;
        }

        public void Update()
        {
            delay++;
            if (delay == totalDelay)
            {
                currentFrame++;
                if (currentFrame == totalFrame)
                {
                    currentFrame = 0;
                }
                delay = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sourceRectangle = new Rectangle(currentFrame*width, 0, width, height);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(image, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }


    }
}
