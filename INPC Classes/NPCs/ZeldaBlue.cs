using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda.NPC_Classes
{
    class ZeldaBlue : INPC
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        public float Scale { get; set; }
        private UtilityClass utilities = new UtilityClass();

        public Rectangle DestinationRectangle;

       

        public ZeldaBlue(Vector2 position)
        {
            Sprite = NPCSpriteFactory.Instance.CreateZeldaBlueIdleSprite();
            State = new NullState();
            Position = position;
            Scale = utilities.Scale;
            DestinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(utilities.width * Scale), (int)(utilities.height * Scale));
        }

        public void Update()
        {
            // TODO
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
