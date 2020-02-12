using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkSwordEastState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkSwordEastState(Link link)
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
            link.state = new LinkDamagedNonMovingEastState(link);
        }
        public void UseItem()
        {
            // no action
        }
        public void UseSword()
        {
            // no action
        }
        public void Update()
        {
            // sword east
            link.state = new LinkNonMovingEastState(link);
        }
    }
}
