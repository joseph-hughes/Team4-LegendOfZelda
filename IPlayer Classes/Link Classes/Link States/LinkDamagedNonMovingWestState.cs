namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingWestState : IState
    {
        private Link link;
        private int timer;
        public LinkDamagedNonMovingWestState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Directon = Vector.Orientation.West;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = true;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedNonMovingWestSprite();
        }
        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link, timer);
        }
        public void North()
        {
            link.State = new LinkDamagedMovingNorthState(link, timer);
        }
        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link, timer);
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void Idle()
        {
            // Do nothing
        }
        public void BeDamaged()
        {
            // Do nothing
        }
        public void UseItem()
        {
            // Do nothing
        }
        public void Attack()
        {
            // Do nothing
        }
        public void Update()
        {
            this.timer -= 1;
            if (this.timer == 0)
            {
                link.CurrentHitPoints--;
                link.State = new LinkNonMovingWestState(link);
                link.isDamaged = false;
            }
        }
    }
}
