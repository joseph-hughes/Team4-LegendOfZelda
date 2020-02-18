using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingEastState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkMovingEastState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingEastSprite();
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
            // no action
        }
        public void West()
        {
            link.State = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            int dtimer = 10;
            link.State = new LinkDamagedMovingEastState(link, dtimer);
        }
        public void UseItem()
        {
            int utimer = 4;
            link.State = new LinkUseItemEastState(link, utimer);
        }
        public void Attack()
        {
            int stimer = 4;
            link.State = new LinkSwordEastState(link, stimer);
        }
        public void Update()
        {
            if (link.Position.X < ThisGame.GraphicsDevice.Viewport.Width)
            {
                link.Position = new Vector2(link.Position.X + 1, link.Position.Y);
            }
        }
    }
}
