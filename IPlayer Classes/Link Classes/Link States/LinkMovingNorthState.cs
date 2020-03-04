using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingNorthState : IState
    {
        private Link link;

        public LinkMovingNorthState(Link link)
        {
            this.link = link;
            this.link.Direction = 0;
            this.link.Velocity = 2;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingNorthSprite();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            link.State = new LinkMovingEastState(link);
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
            link.State = new LinkNonMovingNorthState(link);
        }

        public void BeDamaged()
        {
            link.State = new LinkKnockbackNorthState(link, Link.knockback_timer);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemNorthState(link, Link.use_item_timer);
        }

        public void Attack()
        {
            link.State = new LinkSwordNorthState(link, Link.sword_timer);
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y - link.Velocity);
            link.LinkRectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * Link.linkWidth), (int)(link.Scale * Link.linkHeight));
        }
    }
}
