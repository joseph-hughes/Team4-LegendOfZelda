using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemNorthState : IState
    {
        private Link link;
        private int timer;


        public LinkUseItemNorthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Directon = Vector.Orientation.North;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkUseItemNorthSprite();
            this.link.itemPosition = new Vector2(link.Position.X + this.link.Scale * Link.linkWidth / 2, link.Position.Y);

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
            }
        }
    }
}
