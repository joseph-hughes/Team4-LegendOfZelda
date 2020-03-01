using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingNorthState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;

        public LinkMovingNorthState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingNorthSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));

        }

        public void North()
        {
            // Do nothing
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
            link.State = new LinkNonMovingNorthState(link);
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
            link.attackDirection = 0;
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y - 2);
            link.Rectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * width), (int)(link.Scale * height));
        }
    }
}
