using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class MovingEastLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public MovingEastLinkState(Link link)
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
            // no action
        }
        public void West()
        {
            link.state = new NonMovingWestLinkState(link);
        }
        public void BeDamaged()
        {
            link.state = new DamagedMovingEastLinkState(link);
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
            // move east
        }
    }
}
