using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class DamagedMovingNorthLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public DamagedMovingNorthLinkState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            link.state = new DamagedNonMovingSouthLinkState(link);
        }
        public void North()
        {
            // no action
        }
        public void East()
        {
            link.state = new DamagedNonMovingEastLinkState(link);
        }
        public void West()
        {
            link.state = new DamagedNonMovingWestLinkState(link);
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
            // move north
            // decrement damage timer
        }
    }
}
