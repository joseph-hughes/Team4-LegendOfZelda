using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingEastState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingEastState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkNonMovingEastSprite();
        }
        public void South()
        {
            link.State = new LinkNonMovingSouthState(link);
        }
        public void North()
        {
            link.State = new LinkNonMovingNorthState(link);
        }
        public void East()
        {
            link.State = new LinkMovingEastState(link);
        }
        public void West()
        {
            link.State = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            int dtimer = 10;
            link.State = new LinkDamagedNonMovingEastState(link, dtimer);
        }
        public void UseItem()
        {
            int utimer = 4;
            link.State = new LinkUseItemEastState(link, utimer);
        }
        public void Attack()
        {
            int stimer = 4;
            link.State = new LinkSwordEastState(link, stimer);
        }
        public void Update()
        {
            // no action
        }
    }
}
