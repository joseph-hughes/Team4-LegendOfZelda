namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingWestState : IState
    {
        private Link link;
        private int timer;
        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedNonMovingWestState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedNonMovingWestSprite();
        }
        public void South()
        {
            link.State = new LinkDamagedNonMovingSouthState(link, timer);
        }
        public void North()
        {
            link.State = new LinkDamagedNonMovingNorthState(link, timer);
        }
        public void East()
        {
            link.State = new LinkDamagedNonMovingEastState(link, timer);
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void BeDamaged()
        {
            // no action
        }
        public void UseItem()
        {
            // no action
        }
        public void Attack()
        {
            // no action
        }
        public void Update()
        {
            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkNonMovingWestState(link);
            }
        }
    }
}
