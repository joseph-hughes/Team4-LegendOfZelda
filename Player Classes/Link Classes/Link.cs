using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            State.GoSouth();
        }
        public void North()
        {
            State.GoNorth();
        }
        public void East()
        {
            State.GoEast();
        }
        public void West()
        {
            State.GoWest();
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
