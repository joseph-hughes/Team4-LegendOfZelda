namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingSouthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingSouthState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkNonMovingSouthSprite();

        }
        public void South()
        {
            link.State = new LinkMovingSouthState(link);
        }
        public void North()
        {
            link.State = new LinkNonMovingNorthState(link);
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
            link.State = new LinkDamagedNonMovingSouthState(link, dtimer);
        }
        public void UseItem()
        {
            int utimer = 4;
            link.State = new LinkUseItemSouthState(link, utimer);
        }
        public void Attack()
        {
            int stimer = 4;
            link.State = new LinkSwordSouthState(link, stimer);
        }
        public void Update()
        {
            // no action
        }




    }
}
