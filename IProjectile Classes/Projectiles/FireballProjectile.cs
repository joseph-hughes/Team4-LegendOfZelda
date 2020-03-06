using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    class FireballProjectile : IProjectile
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public int Angle { get; set; }
        private const int width = 8;
        private const int height = 10;

        public FireballProjectile(Vector2 position, int angle)
        {
            Position = position;
            Scale = 3f;
            Angle = angle;
            Sprite = ProjectileSpriteFactory.Instance.CreateFireballSprite();
            DestinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(width * Scale), (int)(height * Scale));

        }

        public void Update()
        {
            float Y = Position.Y;
            float X = Position.X;
            int speed = 5;

            if (Angle == 0)
            {
                Y -= speed;
            }
            else if (Angle == 90)
            {
                X += speed;
            }
            else if (Angle == 180)
            {
                Y += speed;
            }
            else if (Angle == 270)
            {
                X -= speed;
            }

            Position = new Vector2(X, Y);
            DestinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(width * Scale), (int)(height * Scale));
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
