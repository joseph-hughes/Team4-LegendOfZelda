using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemSouthState : IState
    {
        private Link link;
        private int timer;


        public LinkUseItemSouthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Directon = Vector.Orientation.South;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = false;
            this.link.isDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkUseItemSouthSprite();
            this.link.ItemPosition = new Vector2(link.DestinationRectangle.X + this.link.DestinationRectangle.Width / 2, link.DestinationRectangle.Y);

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
            link.State = new LinkKnockbackSouthState(link, Link.knockback_timer);
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
                link.State = new LinkNonMovingSouthState(link);
            }
        }
    }
}
