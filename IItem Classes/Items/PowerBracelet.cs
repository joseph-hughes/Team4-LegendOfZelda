﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class PowerBracelet : IItem
    {
        private const int width = 8;
        private const int height = 14;
        private ISprite itemSprite;
        public Rectangle Rectangle { get; set; }
        public float Scale { get; set; }
        public Vector2 itemLocation { get; set; }

        public PowerBracelet(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreatePowerBracelet();
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
