using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class MovingNorthLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public MovingNorthLinkState(Link link)
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
            // no action
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
            link.state = new DamagedMovingNorthLinkState(link);
        }
        public void UseItem()
        {
            link.state = new UseItemNorthLinkState(link);
        }
        public void UseSword()
        {
            link.state = new SwordNorthLinkState(link);
        }
        public void Update()
        {
            // move north
        }
    }
}
