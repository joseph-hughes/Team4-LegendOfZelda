
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class ItemObjectAnimated : Item
    {
        ISprite itemSprite;
        ItemState itemState;
        Vector2 itemLocation;

        public ItemObjectAnimated(Texture2D image, int rows, int columns, int delayBetweenFrames, Vector2 location, ItemState state)
        {
            itemSprite = new Sprite(image, rows, columns, delayBetweenFrames);
            itemState = state;
            itemLocation = location;
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, itemLocation);
        }
    }
}
