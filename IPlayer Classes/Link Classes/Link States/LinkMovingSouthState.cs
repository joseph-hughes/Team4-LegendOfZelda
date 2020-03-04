using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingSouthState : IState
    {
        private Link link;

        public LinkMovingSouthState(Link link)
        {
            this.link = link;
            this.link.Direction = 2;
            this.link.Velocity = 2;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingSouthSprite();
        }

        public void North()
        {
            link.State = new LinkMovingNorthState(link);
        }

        public void East()
        {
            link.State = new LinkMovingEastState(link);
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            link.State = new LinkMovingWestState(link);
        }

        public void Idle()
        {
            link.State = new LinkNonMovingSouthState(link);
        }

        public void BeDamaged()
        {
            link.State = new LinkKnockbackSouthState(link, Link.knockback_timer);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemSouthState(link, Link.use_item_timer);
        }

        public void Attack()
        {
            link.State = new LinkSwordSouthState(link, Link.sword_timer);
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y + link.Velocity);
            link.LinkRectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * Link.linkWidth), (int)(link.Scale * Link.linkHeight));
        }
    }
}
