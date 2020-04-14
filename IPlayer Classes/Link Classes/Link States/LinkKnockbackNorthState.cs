using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkKnockbackNorthState : IState
    {
        private Link link;
        private int timer;

        public LinkKnockbackNorthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 10;
            this.link.Velocity.Directon = Vector.Orientation.North;
            this.link.isAttacking = false;
            this.link.isKnocked = true;
            this.link.isDamaged = true;
            this.link.isDeath = false;
            this.link.LinkSwordRectangle = Rectangle.Empty;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingNorthSprite();
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Attack()
        {
            // Do nothing
        }

        public void Update()
        {
            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkDamagedNonMovingNorthState(link, Link.damage_timer);
            }
            else
            {
                link.DestinationRectangle = new Rectangle(link.DestinationRectangle.X, link.DestinationRectangle.Y + link.Velocity.Magnitude, link.DestinationRectangle.Width, link.DestinationRectangle.Height);

            }
        }
    }
}

