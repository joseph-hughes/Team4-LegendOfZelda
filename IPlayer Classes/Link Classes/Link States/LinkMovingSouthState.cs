using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingSouthState : IState
    {
        private Link link;

        public LinkMovingSouthState(Link link)
        {
            this.link = link;
            this.link.Velocity.Magnitude = 2;
            this.link.Velocity.Direction = Vector.Orientation.South;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
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
            link.State = new LinkKnockbackSouthState(link, Link.KNOCKBACK_TIMER);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemSouthState(link, Link.USE_ITEM_TIMER);
        }

        public void Attack()
        {
            link.State = new LinkSwordSouthState(link, Link.SWORD_TIMER);
        }

        public void Update()
        {
            link.DestinationRectangle = new Rectangle(link.DestinationRectangle.X, link.DestinationRectangle.Y + link.Velocity.Magnitude, link.DestinationRectangle.Width, link.DestinationRectangle.Height);
        }
    }
}
