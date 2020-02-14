using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemNorthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkUseItemNorthState(Link link)
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
            link.State = new LinkDamagedNonMovingNorthState(link);
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
            // use item north
            link.State = new LinkNonMovingNorthState(link);
        }
    }
}
