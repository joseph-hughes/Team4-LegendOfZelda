using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingNorthState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkMovingNorthState(Link link)
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
            // no action
        }
        public void East()
        {
            link.state = new LinkNonMovingEastState(link);
        }
        public void West()
        {
            link.state = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.state = new LinkDamagedMovingNorthState(link);
        }
        public void UseItem()
        {
            link.state = new LinkUseItemNorthState(link);
        }
        public void UseSword()
        {
            link.state = new LinkSwordNorthState(link);
        }
        public void Update()
        {
            // move north
        }
    }
}
