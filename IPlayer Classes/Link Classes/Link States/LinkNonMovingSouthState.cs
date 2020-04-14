namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingSouthState : IState
    {
        private Link link;

        public LinkNonMovingSouthState(Link link)
        {
            this.link = link;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Direction = Vector.Orientation.South;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkNonMovingSouthSprite();
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
            link.State = new LinkMovingWestState(link);
        }

        public void Idle()
        {
            // Do nothing
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
            // no action
        }
    }
}
