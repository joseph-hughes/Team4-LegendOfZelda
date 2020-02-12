using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class MovingWestLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public MovingWestLinkState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            link.state = new NonMovingSouthLinkState(link);
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
            // no action
        }
        public void BeDamaged()
        {
            link.state = new DamagedMovingWestLinkState(link);
        }
        public void UseItem()
        {
            link.state = new UseItemWestLinkState(link);
        }
        public void UseSword()
        {
            link.state = new SwordWestLinkState(link);
        }
        public void Update()
        {
            // move west
        }
    }
}
