using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingNorthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkMovingNorthState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            link.State = new LinkNonMovingSouthState(link);
        }
        public void North()
        {
            // no action
        }
        public void East()
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
