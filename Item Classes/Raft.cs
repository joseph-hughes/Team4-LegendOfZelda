﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda.Item_Classes
{
    class Raft : Iitem
    {
        ISprite itemSprite;
        Vector2 itemLocation;

        public Raft(Vector2 location)
        {
            itemSprite = ItemSpriteFactory.Instance.CreateRaft();
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