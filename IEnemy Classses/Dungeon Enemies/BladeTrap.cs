using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class BladeTrap : IEnemy
    {
        public ILevel Level { get; set; }
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public BladeTrap(ILevel level, Vector2 position)
        {
            Level = level;
            Sprite = EnemySpriteFactory.Instance.CreateBladeTrapSprite();
            State = new NullState();
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
