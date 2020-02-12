using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class DamagedMovingSouthLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public DamagedMovingSouthLinkState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            // no action
        }
        public void North()
        {
            link.state = new DamagedNonMovingNorthLinkState(link);
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
            // move south
            // decrement damage timer
        }
    }
}
