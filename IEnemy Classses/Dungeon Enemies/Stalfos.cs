using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class Stalfos : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        int count, maxCount;
        Random rand;
        enum Direction { NORTH, EAST, SOUTH, WEST };
        Direction direction;

        public Stalfos(ILevel level, Vector2 position)
        {
            Level = level;
            Sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            State = new NullState();
            Position = position;

            count = 0;
            maxCount = 240;
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
                    Position = new Vector2(Position.X, ((int)Position.Y - 1) % 600);
                    break;
                case Direction.EAST:
                    Position = new Vector2(((int)Position.X + 1) % 800, Position.Y);
                    break;
                case Direction.SOUTH:
                    Position = new Vector2(Position.X, ((int)Position.Y + 1) % 600);
                    break;
                case Direction.WEST:
                    Position = new Vector2(((int)Position.X - 1) % 800, Position.Y);
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
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Position);
        }
    }
}
