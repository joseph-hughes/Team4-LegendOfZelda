using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Vector;

namespace Team4_LegendOfZelda
{
    class ArrowProjectile : IProjectile
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public Orientation Direction { get; set; }

        private int width;
        private int height;

        public ArrowProjectile(Vector2 position, IVector vector)
        {
            Position = position;
            Scale = 3f;
            Direction = vector.Direction;
            if (Direction == Orientation.North)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateArrowUpSprite();
                width = 5;
                height = 16;
            }
            else if (Direction == Orientation.East)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateArrowRightSprite();
                width = 16;
                height = 5;
            }
            else if (Direction == Orientation.South)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateArrowDownSprite();
                width = 5;
                height = 16;
            }
            else if (Direction == Orientation.West)
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
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
