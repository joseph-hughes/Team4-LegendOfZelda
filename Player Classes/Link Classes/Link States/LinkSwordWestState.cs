using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkSwordWestState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkSwordWestState(Link link)
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
            link.State = new LinkDamagedNonMovingWestState(link);
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
            // sword west
            link.State = new LinkNonMovingWestState(link);
        }
    }
}
