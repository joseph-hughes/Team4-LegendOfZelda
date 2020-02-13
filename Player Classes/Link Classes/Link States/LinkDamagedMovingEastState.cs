using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingEastState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedMovingEastState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void GoSouth()
        {
            link.State = new LinkDamagedNonMovingSouthState(link);
        }
        public void GoNorth()
        {
            link.State = new LinkDamagedNonMovingNorthState(link);
        }
        public void GoEast()
        {
            // no action
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
            // move east
            // decrement damage timer
        }
    }
}
