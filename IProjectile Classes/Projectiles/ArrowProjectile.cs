using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    class ArrowProjectile : IProjectile
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public int Angle { get; set; }
        private int width;
        private int height;

        public ArrowProjectile(Vector2 position, int angle)
        {
            Position = position;
            Scale = 3f;
            Angle = angle;

            if (angle == 0)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateArrowUpSprite();
                width = 5;
                height = 16;
            }
            else if (angle == 90)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateArrowRightSprite();
                width = 16;
                height = 5;
            }
            else if (angle == 180)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateArrowDownSprite();
                width = 5;
                height = 16;
            }
            else if (angle == 270)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateArrowLeftSprite();
                width = 16;
                height = 5;
            }

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
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, DestinationRectangle);
        }

        public bool Equals(IProjectile projectile)
        {
            throw new System.NotImplementedException();
        }
    }
}
