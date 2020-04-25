
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class BlueCandle : IItem
    {
       
        private ISprite itemSprite;
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public Vector2 itemLocation { get; set; }

        public BlueCandle(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateBlueCandle(); ;
            itemLocation = location;
            Scale = UtilityClass.Instance.Scale();
            DestinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)(UtilityClass.Instance.BlueCandle_WIDTH() * Scale), (int)(UtilityClass.Instance.BlueCandle_HEIGHT() * Scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, DestinationRectangle);
        }

        public void Update()
        {
            DestinationRectangle = new Rectangle((int)itemLocation.X, (int)itemLocation.Y, (int)(UtilityClass.Instance.BlueCandle_WIDTH() * Scale), (int)(UtilityClass.Instance.BlueCandle_HEIGHT() * Scale));
        }

        public void UseItem()
        {
            //TODO
        }
    }
}
