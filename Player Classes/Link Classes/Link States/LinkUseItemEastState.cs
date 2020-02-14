using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemEastState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkUseItemEastState(Link link)
        {
            this.link = link;
            // contrust sprite
        }
        public void South()
        {
            // no action
        }
        public void North()
        {
            // no action
        }
        public void East()
        {
            // no action
        }
        public void West()
        {
            // no action
        }
        public void BeDamaged()
        {
            link.State = new LinkDamagedNonMovingEastState(link);
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
            // use item east
            link.State = new LinkNonMovingEastState(link);
        }
    }
}
