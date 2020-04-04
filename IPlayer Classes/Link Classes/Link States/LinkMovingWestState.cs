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
            this.link.Velocity.Direction = Vector.Orientation.West;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
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
            link.State = new LinkKnockbackWestState(link, Link.KNOCKBACK_TIMER);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemWestState(link, Link.USE_ITEM_TIMER);
        }

        public void Attack()
        {
            link.State = new LinkSwordWestState(link, Link.SWORD_TIMER);
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X - link.Velocity.Magnitude, link.Position.Y);
            link.DestinationRectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * Link.linkWidth), (int)(link.Scale * Link.linkHeight));
        }
    }
}
