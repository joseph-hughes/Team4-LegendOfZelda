using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    class BlueCandle : IItem
    {
        public ISprite Sprite { get; set; }
        public Vector2 Location { get; set; }

        public BlueCandle(Vector2 location)
        {
            Sprite = ItemSpriteFactory.Instance.CreateBlueCandle();
            Location = location;
        }
        public void Update()
        {
            // TODO
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Location);
        }

        public void UseItem(Vector2 location)
        {
            Location = location;
        }
    }
}
