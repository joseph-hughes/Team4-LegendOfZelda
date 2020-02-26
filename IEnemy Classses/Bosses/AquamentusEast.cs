using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class AquamentusEast : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        int count, maxCount;
        Random rand;
        enum Direction { EAST, WEST };
        Direction direction;

        public AquamentusEast(ILevel level, Vector2 position)
        {
            Level = level;
            State = new AquamentusEastIdleState(this);
            Position = position;

            count = 0;
            maxCount = 240;
            direction = Direction.EAST;
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
                case Direction.EAST:
                    Position = new Vector2(((int)Position.X + 2) % 800, Position.Y);
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
                switch (rand.Next(0, 3))
                {
                    case 0:
                        direction = Direction.EAST;
                        break;
                    case 1:
                        direction = Direction.WEST;
                        break;
                    case 2:
                        State.Attack();
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
