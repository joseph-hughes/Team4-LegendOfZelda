using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingWestState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingWestState(Link link)
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
            link.state = new LinkNonMovingEastState(link);
        }
        public void West()
        {
            link.state = new LinkMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.state = new LinkDamagedNonMovingWestState(link);
        }
        public void UseItem()
        {
            link.state = new LinkUseItemWestState(link);
        }
        public void UseSword()
        {
            link.state = new LinkSwordWestState(link);
        }
        public void Update()
        {
            // no action
        }
    }
}
