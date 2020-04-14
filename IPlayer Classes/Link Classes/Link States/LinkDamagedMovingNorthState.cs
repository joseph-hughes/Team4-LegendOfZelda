using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingNorthState : IState
    {
        private Link link;
        private int timer;


        public LinkDamagedMovingNorthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 2;
            this.link.Velocity.Directon = Vector.Orientation.North;
            this.link.isAttacking = false;
            this.link.isKnocked = false;
            this.link.isDamaged = true;
            this.link.isDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingNorthSprite();
        }

        public void North()
        {
            // no action 
        }
        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link, timer);
        }
        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link, timer);
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void Idle()
        {
            link.State = new LinkDamagedNonMovingNorthState(link, timer);
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
            link.DestinationRectangle = new Rectangle(link.DestinationRectangle.X, link.DestinationRectangle.Y - link.Velocity.Magnitude, link.DestinationRectangle.Width, link.DestinationRectangle.Height);

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkMovingNorthState(link);
                link.isDamaged = false;
            }
        }
    }
}
