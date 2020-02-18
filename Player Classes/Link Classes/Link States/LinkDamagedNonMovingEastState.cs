using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingEastState : IState
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
            link.State = new LinkDamagedNonMovingSouthState(link);
        }
        public void North()
        {
            link.State = new LinkDamagedNonMovingNorthState(link);
        }
        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link);
        }
        public void West()
        {
            link.State = new LinkDamagedNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            // no action
        }
        public void UseItem()
        {
            // no action
        }
        public void Attack()
        {
            // no action
        }
        public void Update()
        {
            // decrement damage timer
        }
    }
}
