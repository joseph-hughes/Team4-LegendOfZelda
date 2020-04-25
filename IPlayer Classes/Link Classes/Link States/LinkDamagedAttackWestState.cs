using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedAttackWestState : IState
    {
        private Link link;
        private int sword_timer;
        private int damage_timer;

        public LinkDamagedAttackWestState(Link link, int sword_timer, int damage_timer)
        {
            this.link = link;
            this.sword_timer = sword_timer;
            this.damage_timer = damage_timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Direction = Vector.Orientation.West;
            this.link.IsAttacking = true;
            this.link.IsKnocked = false;
            this.link.IsDamaged = true;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedSwordWestSprite();
        }

        public void North()
        {
            //no action
        }
        public void East()
        {
            // no action
        }
        public void South()
        {
            //no action
        }
        public void West()
        {
            //no action
        }
        public void Idle()
        {
            //no action
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
            this.sword_timer -= 1;
            this.damage_timer -= 1;
            if (this.sword_timer == 0 && this.damage_timer == 0)
            {
                link.LinkSwordRectangle = Rectangle.Empty;
                link.State = new LinkNonMovingWestState(link);
            }
            else if (this.damage_timer == 0)
            {
                this.damage_timer = this.sword_timer;
            }
            else if (this.sword_timer == 0)
            {
                link.LinkSwordRectangle = Rectangle.Empty;
                link.State = new LinkDamagedNonMovingWestState(link, this.damage_timer);
            }
        }
    }
}