using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingEastState : IState
    {
        private Link link;
        private int timer;

        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedMovingEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingEastSprite();
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
            // no action
        }
        public void West()
        {
            link.State = new LinkDamagedNonMovingWestState(link, timer);
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
            if (link.Position.X < ThisGame.GraphicsDevice.Viewport.Width)
            {
                link.Position = new Vector2(link.Position.X + 1, link.Position.Y);
            }

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkMovingEastState(link);
            }
        }
    }
}
