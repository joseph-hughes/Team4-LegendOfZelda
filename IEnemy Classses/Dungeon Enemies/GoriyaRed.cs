using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class GoriyaRed : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        int count, maxCount;
        Random rand;

        public GoriyaRed(ILevel level, Vector2 position)
        {
            Level = level;
            State = new GoriyaRedWestState(this);
            Position = position;

            count = 0;
            maxCount = 240;
            rand = new Random();
        }

        public void Idle()
        {
            State.Idle();
        }

        public void Update()
        {
            State.Update();
            count++;
            if (count > maxCount)
            {
                switch (rand.Next(0, 6))
                {
                    case 0:
                        State.North();
                        break;
                    case 1:
                        State.East();
                        break;
                    case 2:
                        State.South();
                        break;
                    case 3:
                        State.West();
                        break;
                    case 4:
                        State.Attack();
                        break;
                    case 5:
                        State.BeDamaged();
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
