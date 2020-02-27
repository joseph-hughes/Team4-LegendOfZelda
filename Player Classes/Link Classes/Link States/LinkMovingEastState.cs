using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingEastState : IState
    {
        private Link link;

        public LinkMovingEastState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingEastSprite();
        }

        public void North()
        {
            link.State = new LinkMovingNorthState(link);
        }

        public void East()
        {
            // Do nothing
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
            link.State = new LinkNonMovingEastState(link);
        }

        public void BeDamaged()
        {
            link.State = new LinkKnockbackEastState(link, Link.knockback_timer);
        }

        public void UseItem()
        {
            link.State = new LinkUseItemEastState(link, Link.use_item_timer);
        }

        public void Attack()
        {
            link.State = new LinkSwordEastState(link, Link.sword_timer);
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X + 2, link.Position.Y);
        }
    }
}
