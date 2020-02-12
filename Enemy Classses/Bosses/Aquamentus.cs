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

        public Aquamentus()
        {
            State = new AquamentusLeftFacingIdleState(this);
        }
        public void South()
        {
            State.South();
        }
        public void North()
        {
            State.North();
        }
        public void East()
        {
            State.East();
        }
        public void West()
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
