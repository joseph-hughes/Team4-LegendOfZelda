namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemNorthState : IState
    {
        private Link link;
        private int timer;

        public LegendOfZelda ThisGame { get; set; }
        public LinkUseItemNorthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkUseItemNorthSprite();
        }
        public void South()
        {
            // no action
        }
        public void North()
        {
            // no action
        }
        public void East()
        {
            // no action
        }
        public void West()
        {
            // no action
        }
        public void BeDamaged()
        {
            int dtimer = 10;
            link.State = new LinkDamagedNonMovingNorthState(link, dtimer);
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
                link.State = new LinkNonMovingNorthState(link);
            }
        }
    }
}
