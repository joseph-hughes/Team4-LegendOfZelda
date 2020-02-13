using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingSouthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedMovingSouthState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void GoSouth()
        {
            // no action
        }
        public void GoNorth()
        {
            link.State = new LinkDamagedNonMovingNorthState(link);
        }
        public void GoEast()
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
            // move south
            // decrement damage timer
        }
    }
}
