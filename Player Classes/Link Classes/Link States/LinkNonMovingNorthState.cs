using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingNorthState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingNorthState(Link link)
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
            link.state = new LinkMovingNorthState(link);
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
            link.state = new LinkDamagedNonMovingNorthState(link);
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
            // no action
        }
    }
}
