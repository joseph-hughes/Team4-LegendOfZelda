﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    class MagicBoomerangProjectile : IProjectile
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public float Scale { get; set; }
        public int Angle { get; set; }
        private const int width = 8;
        private const int height = 8;

        public MagicBoomerangProjectile(Vector2 position, int angle)
        {
            Position = position;
            Scale = 3f;
            Angle = angle;
            Sprite = ProjectileSpriteFactory.Instance.CreateMagicBoomerangSprite();
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
                if (Y < 0)
                {
                    Y = 480;
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
                Y += speed;
                if (Y > 480)
                {
                    Y = 0;
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
            DestinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(width * Scale), (int)(height * Scale));
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
