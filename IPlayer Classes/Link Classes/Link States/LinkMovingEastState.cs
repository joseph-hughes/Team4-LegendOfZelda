using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingEastState : IState
    {
        private Link link;

        public LinkMovingEastState(Link link)
        {
            this.link = link;
            this.link.Direction = 1;
            this.link.Velocity = 2;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingEastSprite();

        }

        public void North()
        {
            link.State = new LinkMovingNorthState(link);
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            link.State = new LinkMovingSouthState(link);
        }

        public void West()
        {
            link.State = new LinkMovingWestState(link);
        }

        public void Idle()
        {
            link.State = new LinkNonMovingEastState(link);
        }

        public void BeDamaged()
        {
            link.State = new LinkKnockbackEastState(link, Link.knockback_timer);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemEastState(link, Link.use_item_timer);
        }

        public void Attack()
        {
            link.State = new LinkSwordEastState(link, Link.sword_timer);
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X + link.Velocity, link.Position.Y);
            link.LinkRectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * Link.linkWidth), (int)(link.Scale * Link.linkHeight));
        }
    }
}
