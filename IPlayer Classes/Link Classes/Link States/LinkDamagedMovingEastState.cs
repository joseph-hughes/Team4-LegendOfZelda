using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingEastState : IState
    {
        private Link link;
        private int timer;

        public LinkDamagedMovingEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 2;
            this.link.Velocity.Direction = Vector.Orientation.East;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = true;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingEastSprite();
        }

        public void North()
        {
            link.State = new LinkDamagedMovingNorthState(link, timer);
        }
        public void East()
        {
            // no action
        }
        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link, timer);
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void Freeze()
        {
            // Do nothing
        }
        public void Idle()
        {
            link.State = new LinkDamagedNonMovingEastState(link, timer);
        }
        public void BeDamaged()
        {
            // no action
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
            link.DestinationRectangle = new Rectangle(link.DestinationRectangle.X + link.Velocity.Magnitude, link.DestinationRectangle.Y, link.DestinationRectangle.Width, link.DestinationRectangle.Height);

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkMovingEastState(link);
                link.IsDamaged = false;
            }
        }
    }
}
