using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class KeeseBlue : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle Rectangle { get; set; }
        public float Scale { get; set; }
        private const int width = 16;
        private const int height = 10;
        int count, maxCount;
        Random rand;
        enum Direction { NORTH, EAST, SOUTH, WEST };
        Direction direction;

        public KeeseBlue(ILevel level, Vector2 position)
        {
            Level = level;
            Position = position;
            Scale = 3f;

            Sprite = EnemySpriteFactory.Instance.CreateKeeseBlueSprite();
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(Scale * width), (int)(Scale * height));
            State = new NullState();

            count = 0;
            maxCount = 10;
            direction = Direction.NORTH;
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

            switch (direction)
            {
                case Direction.NORTH:
                    Position = new Vector2(Position.X, ((int)Position.Y - 2) % 600);
                    break;
                case Direction.EAST:
                    Position = new Vector2(((int)Position.X + 2) % 800, Position.Y);
                    break;
                case Direction.SOUTH:
                    Position = new Vector2(Position.X, ((int)Position.Y + 2) % 600);
                    break;
                case Direction.WEST:
                    Position = new Vector2(((int)Position.X - 2) % 800, Position.Y);
                    break;
                default:
                    // Do nothing, this is not supposed to happen
                    break;
            }

            count++;
            if (count > maxCount)
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        direction = Direction.NORTH;
                        break;
                    case 1:
                        direction = Direction.EAST;
                        break;
                    case 2:
                        direction = Direction.SOUTH;
                        break;
                    case 3:
                        direction = Direction.WEST;
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
