
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Key : IItem
    {
        
        private ISprite itemSprite;
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public Vector2 itemLocation { get; set; }

        public Key(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateKey();
            itemLocation = location;
            Scale = UtilityClass.Instance.Scale();
            DestinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)(UtilityClass.Instance.Key_WIDTH() * Scale), (int)(UtilityClass.Instance.Key_HEIGHT() * Scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, DestinationRectangle);
        }

        public void Update()
        {
            DestinationRectangle = new Rectangle((int)itemLocation.X, (int)itemLocation.Y, (int)(UtilityClass.Instance.Key_WIDTH() * Scale), (int)(UtilityClass.Instance.Key_HEIGHT() * Scale));
        }

        public void UseItem()
        {
            //TODO
        }
    }
}
