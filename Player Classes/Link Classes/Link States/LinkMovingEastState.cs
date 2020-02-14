using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingEastState : IState
    {
        private Link link;
        public LegendOfZeldaGame ThisGame { get; set; }
        public LinkMovingEastState(Link link)
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
            // no action
        }
        public void GoWest()
        {
            link.State = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.State = new LinkDamagedMovingEastState(link);
        }
        public void UseItem()
        {
            link.State = new LinkUseItemEastState(link);
        }
        public void Attack()
        {
            link.State = new LinkSwordEastState(link);
        }
        public void Update()
        {
            // move east
        }
    }
}
