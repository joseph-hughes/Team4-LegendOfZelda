using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Bosses.Dodongo_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class Dodongo : IEnemy
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public Dodongo(Vector2 position)
        {
            State = new DodongoWestWalkingState(this);
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
