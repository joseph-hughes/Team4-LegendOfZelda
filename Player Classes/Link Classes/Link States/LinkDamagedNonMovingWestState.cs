using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingWestState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedNonMovingWestState(Link link)
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
            link.State = new LinkDamagedNonMovingEastState(link);
        }
        public void GoWest()
        {
            link.State = new LinkDamagedMovingWestState(link);
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
