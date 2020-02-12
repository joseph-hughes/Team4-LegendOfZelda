using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingEastState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingEastState(Link link)
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
            link.state = new LinkMovingEastState(link);
        }
        public void West()
        {
            link.state = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.state = new LinkDamagedNonMovingEastState(link);
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
            // no action
        }
    }
}
