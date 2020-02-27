
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class MagicalBoomerang : IItem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public MagicalBoomerang(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateMagicalBoomerang();
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
