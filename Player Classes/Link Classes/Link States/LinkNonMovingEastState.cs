using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingEastState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingEastState(Link link)
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
            link.State = new LinkNonMovingNorthState(link);
        }
        public void East()
        {
            link.State = new LinkMovingEastState(link);
        }
        public void West()
        {
            link.State = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.State = new LinkDamagedNonMovingEastState(link);
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
            // no action
        }
    }
}
