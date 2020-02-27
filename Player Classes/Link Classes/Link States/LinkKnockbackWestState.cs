using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkKnockbackWestState : IState
    {
        private Link link;
        private int timer;

        public LinkKnockbackWestState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingWestSprite();
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
            link.Position = new Vector2(link.Position.X + (Link.knockback_distance / Link.knockback_timer), link.Position.Y);

            this.timer -= 1;
            if (this.timer == 0)
                link.State = new LinkDamagedNonMovingWestState(link, Link.damage_timer);
        }
    }
}

