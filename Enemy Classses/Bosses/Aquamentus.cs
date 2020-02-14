using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class Aquamentus : IEnemy
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public Aquamentus(Vector2 position)
        {
            State = new AquamentusWestIdleState(this);
            Position = position;
        }

        public void GoNorth()
        {
            State.GoNorth();
        }

        public void GoEast()
        {
            State.GoEast();
        }

        public void GoSouth()
        {
            State.GoSouth();
        }

        public void GoWest()
        {
            State.GoWest();
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
