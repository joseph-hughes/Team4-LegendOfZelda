using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.WallMaster_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class WallMaster : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        int count, maxCount;
        Random rand;
        enum Direction { NORTH, EAST, SOUTH, WEST };
        Direction direction;

        public WallMaster(ILevel level, Vector2 position)
        {
            Level = level;
            State = new WallMasterWestState(this);
            Position = position;

            count = 0;
            maxCount = 240;
            direction = Direction.NORTH;
            rand = new Random();
        }

        public void North()
        {
            State.North();
        }

        public void East()
        {
            State.East();
        }

        public void South()
        {
            State.South();
        }

        public void West()
        {
            State.West();
        }

        public void BeDamaged()
        {
            State.BeDamaged();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void UseItem()
        {
            State.UseItem();
        }

        public void Update()
        {
            State.Update();
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
                        State.East();
                        break;
                    case 2:
                        direction = Direction.SOUTH;
                        break;
                    case 3:
                        direction = Direction.WEST;
                        State.West();
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
