using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkSwordNorthState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 27;
        private int timer;


        public LinkSwordNorthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkSwordNorthSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)(this.link.Position.Y - this.link.Scale * (height - width)), (int)(this.link.Scale * width), (int)(this.link.Scale * height));
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
        public void Idle()
        {
            // Do nothing
        }
        public void BeDamaged()
        {
            link.State = new LinkKnockbackNorthState(link, Link.knockback_timer);
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
            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkNonMovingNorthState(link);
                link.attackDirection = -1;
            }
        }
    }
}
