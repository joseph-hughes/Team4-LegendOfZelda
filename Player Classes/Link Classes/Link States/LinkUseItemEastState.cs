using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemEastState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;
        private int timer;
        private int ID;


        public LinkUseItemEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkUseItemEastSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
            ID = link.currentUseItemID;
            if (ID == 0)
            {
                this.link.currentProjectile = new ArrowProjectile(link.Position, 90);
            }
            else if (ID == 1)
            {
                this.link.currentProjectile = new BoomerangProjectile(link.Position, 90);
            }
            else if (ID == 2)
            {
                this.link.currentProjectile = new FireballProjectile(link.Position, 90);
            }
            else if (ID == 3)
            {
                this.link.currentProjectile = new MagicBoomerangProjectile(link.Position, 90);
            }
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
            link.State = new LinkKnockbackEastState(link, Link.knockback_timer);
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
                link.State = new LinkNonMovingEastState(link);
            }
        }
    }
}
