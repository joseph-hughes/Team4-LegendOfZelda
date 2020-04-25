using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Vector;

namespace Team4_LegendOfZelda
{
    class BoomerangProjectile : IProjectile
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public Orientation Direction { get; set; }
        public float Scale { get; set; }
        private const int width = 8;
        private const int height = 8;

        public BoomerangProjectile(Vector2 position, IVector vector)
        {
            Position = position;
            Scale = 3f;
            Direction = vector.Direction;
            Sprite = ProjectileSpriteFactory.Instance.CreateBoomerangSprite();
            DestinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(width * Scale), (int)(height * Scale));

        }

        public void Update()
        {
            float Y = Position.Y;
            float X = Position.X;
            int speed = 5;

            if (Direction == Orientation.North)
            {
                Y -= speed;
            }
            else if (Direction == Orientation.East)
            {
                X += speed;
            }
            else if (Direction == Orientation.South)
            {
                Y += speed;
            }
            else if (Direction == Orientation.West)
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
