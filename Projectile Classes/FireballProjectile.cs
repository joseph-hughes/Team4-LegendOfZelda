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
            int speed = 3;

            if (Angle == 0)
            {
                Y -= speed;
                if (Y < 0)
                {
                    //TODO
                }


            }
            else if (Angle == 90)
            {
                X += speed;
                if (X > 800)
                {
                    //TODO
                }
            }
            else if (Angle == 180)
            {
                Y += speed;
                if (Y > 480)
                {
                   //TODO
                }
            }
            else if (Angle == 270)
            {
                X -= speed;
                if (X < 0)
                {
                    //TODO
                }
            }

            Position = new Vector2(X, Y);
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Position);
        }
    }
}
