
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Sword : IItem
    {
        private const int width = 7;
        private const int height = 16;
        private ISprite itemSprite;
        public Rectangle Rectangle;
        public float Scale { get; set; }
        public Vector2 itemLocation { get; set; }

        public Sword(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateSword();
            itemLocation = location;
            Scale = 3f;
            Rectangle = new Rectangle((int)location.X, (int)location.Y, (int)(width * Scale), (int)(height * Scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, Rectangle);
        }

        public void Update()
        {
            Rectangle = new Rectangle((int)itemLocation.X, (int)itemLocation.Y, (int)(width * Scale), (int)(height * Scale));
        }

        public void UseItem()
        {
            //TODO
        }
    }
}