
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Sword : IItem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public Sword(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateSword();
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