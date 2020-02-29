using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    class MagicBoomerangProjectile : IProjectile
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }

        public float speed { get; set; }

        public int Angle { get; set; }
        public MagicBoomerangProjectile(Vector2 position, int angle)
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateMagicBoomerangSprite();
            Position = position;
            Angle = angle;
            speed = 10;
        }

        public void Update()
        {
            float Y = Position.Y;
            float X = Position.X;

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
            speed -= 0.2f;
            Position = new Vector2(X, Y);
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (speed >= -10f)
            {
                Sprite.Draw(spriteBatch, Position);
            }
        }
    }
}
