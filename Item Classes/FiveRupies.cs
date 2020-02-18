
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class FiveRupies : IItem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public FiveRupies(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateFiveRupies();
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
