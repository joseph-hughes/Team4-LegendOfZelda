using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingEastState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedNonMovingEastState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            link.state = new LinkDamagedNonMovingSouthState(link);
        }
        public void North()
        {
            link.state = new LinkDamagedNonMovingNorthState(link);
        }
        public void East()
        {
            link.state = new LinkDamagedMovingEastState(link);
        }
        public void West()
        {
            link.state = new LinkDamagedNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            // no action
        }
        public void UseItem()
        {
            // no action
        }
        public void UseSword()
        {
            // no action
        }
        public void Update()
        {
            // decrement damage timer
        }
    }
}
