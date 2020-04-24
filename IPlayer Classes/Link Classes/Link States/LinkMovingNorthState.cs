using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingNorthState : IState
    {
        private Link link;

        public LinkMovingNorthState(Link link)
        {
            this.link = link;
            this.link.Velocity.Magnitude = 2;
            this.link.Velocity.Direction = Vector.Orientation.North;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
            this.link.IsDeath = false;
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
        public void Freeze()
        {
            // Do nothing
        }
        public void Idle()
        {
            link.State = new LinkNonMovingNorthState(link);
        }

        public void BeDamaged()
        {
            link.State = new LinkKnockbackNorthState(link, Link.KNOCKBACK_TIMER);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemNorthState(link, Link.USE_ITEM_TIMER);
        }

        public void Attack()
        {
            link.State = new LinkSwordNorthState(link, Link.SWORD_TIMER);
        }

        public void Update()
        {
            link.DestinationRectangle = new Rectangle(link.DestinationRectangle.X, link.DestinationRectangle.Y - link.Velocity.Magnitude, link.DestinationRectangle.Width, link.DestinationRectangle.Height);
        }
    }
}
