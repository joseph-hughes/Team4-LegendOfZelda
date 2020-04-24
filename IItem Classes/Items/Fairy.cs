
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Fairy : IItem
    {
        private const int width = 8;
        private const int height = 16;
        private ISprite itemSprite;
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public Vector2 itemLocation { get; set; }

        public Fairy(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateFairy();
            itemLocation = location;
            Scale = 3f;
            DestinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)(width * Scale), (int)(height * Scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, DestinationRectangle);
        }
        public void Update(Rectangle rectangle)
        {
            DestinationRectangle = rectangle;
        }

        public void UseItem(IPlayer player, IRoom room)
        {
            //TODO
        }
    }
}
