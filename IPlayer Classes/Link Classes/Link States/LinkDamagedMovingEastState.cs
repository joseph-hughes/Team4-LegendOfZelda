using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingEastState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;
        private int timer;

        public LinkDamagedMovingEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.attackDirection = -1;
            this.link.isDamaged = true;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingEastSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
        }

        public void North()
        {
            link.State = new LinkDamagedMovingNorthState(link, timer);
        }
        public void East()
        {
            // no action
        }
        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link, timer);
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void Idle()
        {
            link.State = new LinkDamagedNonMovingEastState(link, timer);
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
            link.Position = new Vector2(link.Position.X + 2, link.Position.Y);
            link.Rectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * width), (int)(link.Scale * height));

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkMovingEastState(link);
            }
        }
    }
}
