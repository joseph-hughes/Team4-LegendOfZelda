using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemSouthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkUseItemSouthState(Link link)
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
            link.State = new LinkDamagedNonMovingSouthState(link);
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
            // use item south
            link.State = new LinkNonMovingSouthState(link);
        }
    }
}
