using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.NPC_Classes
{
    class ZeldaRed : INPC
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public ZeldaRed(Vector2 position)
        {
            Sprite = NPCSpriteFactory.Instance.CreateZeldaRedIdleSprite();
            State = new NullState();
            Position = position;
        }

        public void Update()
        {
            // TODO
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Position);
        }
    }
}
