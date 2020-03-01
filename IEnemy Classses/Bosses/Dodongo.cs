using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class Dodongo : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle Rectangle { get; set; }
        public float Scale { get; set; }
        int count, maxCount;
        Random rand;

        public Dodongo(ILevel level, Vector2 position)
        {
            Level = level;
            Scale = 3f;
            Position = position;
            State = new DodongoWestWalkingState(this);

            count = 0;
            maxCount = 60;
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

        public void Idle()
        {
            State.Idle();
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
            count++;
            if (count > maxCount)
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        State.North();
                        break;
                    case 1:
                        State.South();
                        break;
                    case 2:
                        State.East();
                        break;
                    case 3:
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
            Sprite.Draw(spriteBatch, Rectangle);
        }
    }
}
