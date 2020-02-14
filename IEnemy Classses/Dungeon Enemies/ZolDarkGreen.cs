using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class ZolDarkGreen : IEnemy
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public ZolDarkGreen(Vector2 position)
        {
            Sprite = EnemySpriteFactory.Instance.CreateZolDarkGreenSprite();
            State = new NullState();
            Position = position;
        }

        public void GoNorth()
        {
            // TODO
        }

        public void GoEast()
        {
            // TODO
        }

        public void GoSouth()
        {
            // TODO
        }

        public void GoWest()
        {
            // TODO
        }

        public void BeDamaged()
        {
            // TODO
        }

        public void Attack()
        {
            // TODO
        }

        public void UseItem()
        {
            // Do nothing
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
