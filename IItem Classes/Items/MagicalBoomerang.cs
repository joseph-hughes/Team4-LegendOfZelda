﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class MagicalBoomerang : IItem
    {
        private const int width = 5;
        private const int height = 8;
        private ISprite itemSprite;
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public Vector2 itemLocation { get; set; }

        public MagicalBoomerang(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateMagicalBoomerang();
            itemLocation = location;
            Scale = 3f;
            DestinationRectangle = new Rectangle((int)location.X, (int)location.Y, (int)(width * Scale), (int)(height * Scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            itemSprite.Draw(spriteBatch, DestinationRectangle);
        }

        public void Update()
        {
            DestinationRectangle = new Rectangle((int)itemLocation.X, (int)itemLocation.Y, (int)(width * Scale), (int)(height * Scale));
        }

        public void UseItem()
        {
            //TODO
        }
    }
}
