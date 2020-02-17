using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    class FireballProjectile : IProjectile
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }

        public int Angle { get; set; }


        public FireballProjectile(Vector2 position, int angle)
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateFireballSprite();
            Position = position;
            Angle = angle;

        }

        public void Update()
        {
            float Y = Position.Y;
            float X = Position.X;
            int speed = 5;

            if (Angle == 0)
            {
                Y += speed;
                if (Y > 480)
                {

                    Y = 0;
                }

            }
            else if (Angle == 90)
            {
                X += speed;
                if (X > 800)
                {
                    X = 0;
                }
            }
            else if (Angle == 180)
            {
                Y -= speed;
                if (Y < 0)
                {
                    Y = 480;
                }
            }
            else if (Angle == 270)
            {
                X -= speed;
                if (X < 0)
                {
                    X = 800;
                }
            }

            Position = new Vector2(X, Y);

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Sprite.Draw(spriteBatch, position);
        }
    }
}
