using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    class BoomerangProjectile : IProjectile
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }

        public int Angle { get; set; }

        public float speed { get; set; }
        public BoomerangProjectile(Vector2 position, int angle)
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateBoomerangSprite();
            Position = position;
            Angle = angle;
            speed = 5f;
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
            speed -= 0.07f;
            Position = new Vector2(X, Y);
            Sprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (speed >= -5f) 
            { 
                Sprite.Draw(spriteBatch, Position); 
            }
            
        }
    }
}
