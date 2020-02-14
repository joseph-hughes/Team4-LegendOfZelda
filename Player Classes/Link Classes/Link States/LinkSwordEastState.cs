using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkSwordEastState : IState
    {
        private Link link;
        public LegendOfZeldaGame ThisGame { get; set; }
        public LinkSwordEastState(Link link)
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
            // no action
        }
        public void GoEast()
        {
            // no action
        }
        public void GoWest()
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
            // sword east
            link.State = new LinkNonMovingEastState(link);
        }
    }
}
