using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingEastState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkMovingEastState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            link.state = new LinkNonMovingSouthState(link);
        }
        public void North()
        {
            link.state = new LinkNonMovingNorthState(link);
        }
        public void East()
        {
            // no action
        }
        public void West()
        {
            link.state = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.state = new LinkDamagedMovingEastState(link);
        }
        public void UseItem()
        {
            link.state = new LinkUseItemEastState(link);
        }
        public void UseSword()
        {
            link.state = new LinkSwordEastState(link);
        }
        public void Update()
        {
            // move east
        }
    }
}
