using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class DamagedNonMovingEastLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public DamagedNonMovingEastLinkState(Link link)
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
            link.state = new DamagedNonMovingNorthLinkState(link);
        }
        public void East()
        {
            link.state = new DamagedMovingEastLinkState(link);
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
            // decrement damage timer
        }
    }
}
