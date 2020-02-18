namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingNorthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingNorthState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkNonMovingNorthSprite();
        }
        public void South()
        {
            link.State = new LinkNonMovingSouthState(link);
        }
        public void North()
        {
            link.State = new LinkMovingNorthState(link);
        }
        public void East()
        {
            link.State = new LinkNonMovingEastState(link);
        }
        public void West()
        {
            link.State = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            int dtimer = 10;
            link.State = new LinkDamagedNonMovingNorthState(link, dtimer);
        }
        public void UseItem()
        {
            int utimer = 4;
            link.State = new LinkUseItemNorthState(link, utimer);
        }
        public void Attack()
        {
            int stimer = 4;
            link.State = new LinkSwordNorthState(link, stimer);
        }
        public void Update()
        {
            // no action
        }
    }
}
