using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingSouthState : IState
    {
        private Link link;
        public LegendOfZeldaGame ThisGame { get; set; }
        public LinkMovingSouthState(Link link)
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
            link.State = new LinkNonMovingNorthState(link);
        }
        public void GoEast()
        {
            link.State = new LinkNonMovingEastState(link);
        }
        public void GoWest()
        {
            link.State = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.State = new LinkDamagedMovingSouthState(link);
        }
        public void UseItem()
        {
            link.State = new LinkUseItemSouthState(link);
        }
        public void Attack()
        {
            link.State = new LinkSwordSouthState(link);
        }
        public void Update()
        {
            // move south
        }
    }
}
