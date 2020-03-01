using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingSouthState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;

        public LinkMovingSouthState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingSouthSprite();
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
            // Do nothing
        }

        public void West()
        {
            link.State = new LinkMovingWestState(link);
        }

        public void Idle()
        {
            link.State = new LinkNonMovingSouthState(link);
        }

        public void BeDamaged()
        {
            link.State = new LinkKnockbackSouthState(link, Link.knockback_timer);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemSouthState(link, Link.use_item_timer);
        }

        public void Attack()
        {
            link.State = new LinkSwordSouthState(link, Link.sword_timer);
            link.attackDirection = 2;
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y + 2);
            link.Rectangle = new Rectangle((int)link.Position.X, (int)link.Position.Y, (int)(link.Scale * width), (int)(link.Scale * height));
        }
    }
}
