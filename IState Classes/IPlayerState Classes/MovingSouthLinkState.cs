using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class MovingSouthLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public MovingSouthLinkState(Link link)
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
            link.state = new NonMovingNorthLinkState(link);
        }
        public void East()
        {
            link.state = new NonMovingEastLinkState(link);
        }
        public void West()
        {
            link.state = new NonMovingWestLinkState(link);
        }
        public void BeDamaged()
        {
            link.state = new DamagedMovingSouthLinkState(link);
        }
        public void UseItem()
        {
            link.state = new UseItemSouthLinkState(link);
        }
        public void UseSword()
        {
            link.state = new SwordSouthLinkState(link);
        }
        public void Update()
        {
            // move south
        }
    }
}
