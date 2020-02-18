
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class LifePotion : IItem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public LifePotion(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateLifePotion();
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
