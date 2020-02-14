using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Dungeon_Enemies.GoriyaRed_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies
{
    class GoriyaRed : IEnemy
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public GoriyaRed(Vector2 position)
        {
            State = new GoriyaRedWestState(this);
            Position = position;
        }

        public void GoNorth()
        {
            State.North();
        }

        public void GoEast()
        {
            State.East();
        }

        public void GoSouth()
        {
            State.South();
        }

        public void GoWest()
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
