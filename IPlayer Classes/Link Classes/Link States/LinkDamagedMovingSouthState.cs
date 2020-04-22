using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingSouthState : IState
    {
        private Link link;
        private int timer;


        public LinkDamagedMovingSouthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 2;
            this.link.Velocity.Direction = Vector.Orientation.South;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = true;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingSouthSprite();
        }

        public void North()
        {
            link.State = new LinkDamagedMovingNorthState(link, timer);
        }
        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link, timer);
        }
        public void South()
        {
            // no action
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void Idle()
        {
            link.State = new LinkDamagedNonMovingSouthState(link, timer);
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
            link.State = new LinkDamagedAttackSouthState(link, Link.SWORD_TIMER, timer);
        }
        public void Update()
        {
            link.DestinationRectangle = new Rectangle(link.DestinationRectangle.X, link.DestinationRectangle.Y + link.Velocity.Magnitude, link.DestinationRectangle.Width, link.DestinationRectangle.Height);

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkMovingSouthState(link);
                link.IsDamaged = false;
            }
        }
    }
}
