using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingEastState : IState
    {
        private Link link;
        
        public LinkNonMovingEastState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkNonMovingEastSprite();
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
            // Do nothing
        }
    }
}
