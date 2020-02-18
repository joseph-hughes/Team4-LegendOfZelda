
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class BlueCandle : IItem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public BlueCandle(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateBlueCandle();
            itemLocation = location;
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, itemLocation);
        }

        public void UseItem(Vector2 location)
        {
            itemLocation = location;
        }
    }
}
