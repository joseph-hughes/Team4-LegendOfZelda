using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingEastState : IState
    {
        private Link link;

        public LinkMovingEastState(Link link)
        {
            this.link = link;
            this.link.Velocity.Magnitude = 2;
            this.link.Velocity.Direction = Vector.Orientation.East;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingEastSprite();

        }

        public void North()
        {
            link.State = new LinkMovingNorthState(link);
        }

        public void East()
        {
            // If Link collides with pickup item that needs sprite
            //link.State = new PickupItemState(link);
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
            link.State = new LinkNonMovingEastState(link);
        }

        public void BeDamaged()
        {
            link.State = new LinkKnockbackEastState(link, Link.KNOCKBACK_TIMER);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemEastState(link, Link.USE_ITEM_TIMER);
        }

        public void Attack()
        {
            link.State = new LinkSwordEastState(link, Link.SWORD_TIMER);
        }

        public void Update()
        {
            link.DestinationRectangle = new Rectangle(link.DestinationRectangle.X + link.Velocity.Magnitude, link.DestinationRectangle.Y, link.DestinationRectangle.Width, link.DestinationRectangle.Height);
        }
    }
}
