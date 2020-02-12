using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class NonMovingEastLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public NonMovingEastLinkState(Link link)
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
            link.state = new MovingEastLinkState(link);
        }
        public void West()
        {
            link.state = new NonMovingWestLinkState(link);
        }
        public void BeDamaged()
        {
            link.state = new DamagedNonMovingEastLinkState(link);
        }
        public void UseItem()
        {
            link.state = new UseItemEastLinkState(link);
        }
        public void UseSword()
        {
            link.state = new SwordEastLinkState(link);
        }
        public void Update()
        {
            // no action
        }
    }
}
