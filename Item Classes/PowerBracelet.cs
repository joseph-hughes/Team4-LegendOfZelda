
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class PowerBracelet : Iitem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public PowerBracelet(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreatePowerBracelet();
            itemLocation = location;
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, itemLocation);
        }
        public void UseItem()
        {

        }
    }
}
