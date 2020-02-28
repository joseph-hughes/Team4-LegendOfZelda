using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.NPC_Classes
{
    class MerchantRed : INPC
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        public float Scale { get; set; }

        public Rectangle Rectangle;

        private const int width = 14;
        private const int height = 16;

        public MerchantRed(Vector2 position)
        {
            Sprite = NPCSpriteFactory.Instance.CreateMerchantRedSprite();
            State = new NullState();
            Position = position;
            Scale = 3f;
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(width * Scale), (int)(height * Scale));
        }

        public void Update()
        {
            // TODO
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Rectangle);
        }
    }
}
