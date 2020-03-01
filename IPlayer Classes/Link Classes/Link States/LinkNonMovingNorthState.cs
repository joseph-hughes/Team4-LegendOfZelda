using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingNorthState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;
        public LinkNonMovingNorthState(Link link)
        {
            this.link = link;
            this.link.attackDirection = -1;
            this.link.isDamaged = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkNonMovingNorthSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
        }

        public void North()
        {
            link.State = new LinkMovingNorthState(link);
        }

        public void East()
        {
            link.State = new LinkMovingEastState(link);
        }

        public void South()
        {
            link.State = new LinkMovingSouthState(link);
        }

        public void West()
        {
            link.State = new LinkMovingWestState(link);
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
            link.State = new LinkUseItemNorthState(link, Link.use_item_timer);
        }

        public void Attack()
        {
            link.State = new LinkSwordNorthState(link, Link.sword_timer);
        }

        public void Update()
        {
            // no action
        }
    }
}
