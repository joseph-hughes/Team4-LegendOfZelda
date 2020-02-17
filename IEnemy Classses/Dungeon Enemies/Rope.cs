using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.Rope_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class Rope : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public Rope(ILevel level, Vector2 position)
        {
            Level = level;
            State = new RopeWestState(this);
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
