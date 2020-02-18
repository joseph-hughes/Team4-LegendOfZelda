using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda
{
    public class Link : IPlayer
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }

        public Link()
        {
            State = new LinkNonMovingSouthState(this);
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
        public void UseItem()
        {
            State.UseItem();
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
