using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkKnockbackSouthState : IState
    {
        private Link link;
        private int timer;

        public LinkKnockbackSouthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingSouthSprite();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Attack()
        {
            // Do nothing
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y - (Link.knockback_distance / Link.knockback_timer));

            this.timer -= 1;
            if (this.timer == 0)
                link.State = new LinkDamagedNonMovingSouthState(link, Link.damage_timer);
        }
    }
}

