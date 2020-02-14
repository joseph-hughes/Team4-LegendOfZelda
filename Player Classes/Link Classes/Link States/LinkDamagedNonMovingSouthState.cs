using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingSouthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedNonMovingSouthState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link);
        }
        public void North()
        {
            link.State = new LinkDamagedNonMovingNorthState(link);
        }
        public void East()
        {
            link.State = new LinkDamagedNonMovingEastState(link);
        }
        public void GoWest()
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
