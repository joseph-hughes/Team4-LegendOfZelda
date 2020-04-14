using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingWestState : IState
    {
        private Link link;

        public LinkMovingWestState(Link link)
        {
            this.link = link;
            this.link.Velocity.Magnitude = 2;
            this.link.Velocity.Directon = Vector.Orientation.West;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = false;
            this.link.isDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingWestSprite();
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
            link.State = new LinkMovingSouthState(link);
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            link.State = new LinkNonMovingWestState(link);
        }

        public void BeDamaged()
        {
            link.State = new LinkKnockbackWestState(link, Link.knockback_timer);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemWestState(link, Link.use_item_timer);
        }

        public void Attack()
        {
            link.State = new LinkSwordWestState(link, Link.sword_timer);
        }

        public void Update()
        {
            link.DestinationRectangle = new Rectangle(link.DestinationRectangle.X - link.Velocity.Magnitude, link.DestinationRectangle.Y, link.DestinationRectangle.Width, link.DestinationRectangle.Height);
        }
    }
}
