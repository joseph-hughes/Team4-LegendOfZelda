using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class ZolDarkGreen : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle Rectangle { get; set; }
        public float Scale { get; set; }
        private const int width = 14;
        private const int height = 16;
        int count, maxCount;
        Random rand;

        public ZolDarkGreen(ILevel level, Vector2 position)
        {
            Level = level;
            Position = position;
            Scale = 3f;

            Sprite = EnemySpriteFactory.Instance.CreateZolDarkGreenSprite();
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(Scale * width), (int)(Scale * height));
            State = new NullState();


            count = 0;
            maxCount = 10;
            rand = new Random();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void Attack()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Update()
        {
            Sprite.Update();

            count++;
            if (count > maxCount)
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        Position = new Vector2(Position.X, ((int)Position.Y - 10) % 600);
                        break;
                    case 1:
                        Position = new Vector2(((int)Position.X + 10) % 800, Position.Y);
                        break;
                    case 2:
                        Position = new Vector2(Position.X, ((int)Position.Y + 10) % 600);
                        break;
                    case 3:
                        Position = new Vector2(((int)Position.X - 10) % 800, Position.Y);
                        break;
                    default:
                        // Do nothing, this is not supposed to happen
                        break;
                }
                count = 0;
            }
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(Scale * width), (int)(Scale * height));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Rectangle);
        }
    }
}
