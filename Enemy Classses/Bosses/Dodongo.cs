using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Enemy_Classses.Bosses.Aquamentus_States;

namespace Team4_LegendOfZelda.IEnemy_Classses.Bosses
{
    class Dodongo : IEnemy
    {
        public ISprite Sprite { get; set; }
        public IEnemyState State { get; set; }
        public Vector2 Position { get; set; }

        public Dodongo()
        {
            State = new DodongoLeftFacingIdleState(this);
        }

        public void GoLeft()
        {
            State.GoLeft();
        }

        public void GoRight()
        {
            State.GoRight();
        }

        public void GoUp()
        {
            State.GoUp();
        }

        public void GoDown()
        {
            State.GoDown();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void BeHit()
        {
            State.BeHit();
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
