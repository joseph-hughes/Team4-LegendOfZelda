using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingNorthState : IState
    {
        private Link link;
        public LegendOfZeldaGame ThisGame { get; set; }
        public LinkNonMovingNorthState(Link link)
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
            link.State = new LinkMovingNorthState(link);
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
            link.State = new LinkDamagedNonMovingNorthState(link);
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
            // no action
        }
    }
}
