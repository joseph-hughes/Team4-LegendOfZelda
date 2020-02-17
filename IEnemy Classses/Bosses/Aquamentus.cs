using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class Aquamentus : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public Aquamentus(ILevel level, Vector2 position)
        {
            Level = level;
            State = new AquamentusWestIdleState(this);
            Position = position;
        }

        public void Update()
        {
            // TODO
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Position);
        }
    }
}
