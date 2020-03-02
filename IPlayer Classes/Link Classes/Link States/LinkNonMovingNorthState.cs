namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingNorthState : IState
    {
        private Link link;
        public LinkNonMovingNorthState(Link link)
        {
            this.link = link;
            this.link.Direction = 0;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkNonMovingNorthSprite();
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
            // no action
        }
    }
}
