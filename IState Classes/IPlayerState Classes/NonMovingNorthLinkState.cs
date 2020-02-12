using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class NonMovingNorthLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public NonMovingNorthLinkState(Link link)
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
            link.state = new MovingNorthLinkState(link);
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
            link.state = new DamagedNonMovingNorthLinkState(link);
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
            // no action
        }
    }
}
