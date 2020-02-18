﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Compass : IItem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public Compass(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateCompass();
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
