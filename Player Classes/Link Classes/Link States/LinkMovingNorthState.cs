using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingNorthState : IState
    {
        private Link link;
        public LegendOfZeldaGame ThisGame { get; set; }
        public LinkMovingNorthState(Link link)
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
            // no action
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
            link.State = new LinkDamagedMovingNorthState(link);
        }
        public void UseItem()
        {
            link.State = new LinkUseItemNorthState(link);
        }
        public void Attack()
        {
            link.State = new LinkSwordNorthState(link);
        }
        public void Update()
        {
            // move north
        }
    }
}
