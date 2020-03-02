using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingWestState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;
        private int timer;


        public LinkDamagedMovingWestState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Direction = 3;
            this.link.Velocity = 2;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = true;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingWestSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
        }

        public void North()
        {
            link.State = new LinkDamagedMovingNorthState(link, timer);
        }
        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link, timer);
        }
        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link, timer);
        }
        public void West()
        {
            // Do nothing
        }
        public void Idle()
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
            link.Position = new Vector2(link.Position.X - link.Velocity, link.Position.Y);
            link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(link.Scale * height));

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkMovingWestState(link);
                link.isDamaged = false;
            }
        }
    }
}
