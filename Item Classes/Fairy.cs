
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Fairy : IItem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public Fairy(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateFairy();
            itemLocation = location;
        }
        public void Update()
        {
            itemSprite.Update();
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
