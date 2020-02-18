
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class ItemObject : Item
    {
        ISprite itemSprite;
        ItemState itemState;
        Vector2 itemLocation;

        public ItemObject(Texture2D image, Vector2 location, ItemState state)
        {
            itemSprite = new TextureSprite(image);
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
