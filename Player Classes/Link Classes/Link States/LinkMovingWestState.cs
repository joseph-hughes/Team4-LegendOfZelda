using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingWestState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkMovingWestState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void GoSouth()
        {
            link.State = new LinkNonMovingSouthState(link);
        }
        public void GoNorth()
        {
            link.State = new LinkNonMovingNorthState(link);
        }
        public void GoEast()
        {
            link.State = new LinkNonMovingEastState(link);
        }
        public void GoWest()
        {
            // no action
        }
        public void BeDamaged()
        {
            link.State = new LinkDamagedMovingWestState(link);
        }
        public void UseItem()
        {
            link.State = new LinkUseItemWestState(link);
        }
        public void Attack()
        {
            link.State = new LinkSwordWestState(link);
        }
        public void Update()
        {
            // move west
        }
    }
}
