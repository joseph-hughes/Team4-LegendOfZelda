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
            this.link.Velocity.Direction = Vector.Orientation.South;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
            this.link.IsDeath = false;
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
        public void Freeze()
        {
            // Do nothing
        }
        public void Idle()
        {
            // Do nothing
        }
        public void BeDamaged()
        {
            link.State = new LinkKnockbackSouthState(link, Link.KNOCKBACK_TIMER);
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
