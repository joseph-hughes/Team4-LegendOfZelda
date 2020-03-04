// NOT USED. JUST USE AS A REFERENCE FOR WHEN LEVEL DOES TRANSITIONS

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ISprite_Classes
{
    class MapSprite
    {
        private Texture2D texture;
        private int rows;
        private int columns;
        private int currentXPos;
        private int currentYPos;
        private int targetXPos;
        private int targetYPos;
        private int width;
        private int height;
        private Rectangle sourceRectangle;

        public MapSprite(Texture2D texture, int sheetRows, int sheetColumns, int numRowsDownFromTop, int numColumnsOverFromLeft)
        {
            this.texture = texture;

            rows = sheetRows;
            columns = sheetColumns;

            width = texture.Width / columns;
            height = texture.Height / rows;

            currentXPos = numColumnsOverFromLeft * width;
            currentYPos = numRowsDownFromTop * height;
            targetXPos = currentXPos;
            targetYPos = currentYPos;

            sourceRectangle = new Rectangle(currentXPos, currentYPos, width, height);
        }

        public void North()
        {
            targetYPos = currentYPos - height;
            while (currentYPos != targetYPos)
            {
                sourceRectangle = new Rectangle(currentXPos, currentYPos--, width, height);
                // Draw the room, but missing spritebatch...
            }
        }

        public void East()
        {
            targetXPos = currentXPos + width;
            while (currentXPos != targetXPos)
            {

            }
        }

        public void South()
        {
            targetYPos = currentYPos + height;
            while (currentXPos != targetXPos)
            {

            }
        }

        public void West()
        {
            targetXPos = currentXPos - width;
            while (currentXPos != targetXPos)
            {

            }
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
