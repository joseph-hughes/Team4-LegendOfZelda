using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingWestState : IState
    {
        private Link link;
        private int timer;

        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedMovingWestState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingWestSprite();
        }
        public void South()
        {
            link.State = new LinkDamagedNonMovingSouthState(link, timer);
        }
        public void North()
        {
            link.State = new LinkDamagedNonMovingNorthState(link, timer);
        }
        public void East()
        {
            link.State = new LinkDamagedNonMovingEastState(link, timer);
        }
        public void West()
        {
            // no action
        }
        public void BeDamaged()
        {
            // no action
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
            if (link.Position.X > 0)
                link.Position = new Vector2(link.Position.X - 1, link.Position.Y);
            this.timer -= 1;
            if (this.timer == 0)
                link.State = new LinkMovingWestState(link);
        }
    }
}
