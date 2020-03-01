using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemEastState : IState
    {
        private Link link;
        private const int width = 16;
        private const int height = 16;
        private Vector2 itemPosition;
        private int timer;
        private int ID;


        public LinkUseItemEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.attackDirection = -1;
            this.link.isDamaged = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkUseItemEastSprite();
            this.link.Rectangle = new Rectangle((int)this.link.Position.X, (int)this.link.Position.Y, (int)(this.link.Scale * width), (int)(this.link.Scale * height));
            ID = link.currentUseItemID;
            itemPosition = new Vector2(link.Position.X, link.Position.Y + this.link.Scale * height/2);
            if (ID == 0)
            {
                this.link.currentProjectile = new ArrowProjectile(itemPosition, 90);
            }
            else if (ID == 1)
            {
                this.link.currentProjectile = new BoomerangProjectile(itemPosition, 90);
            }
            else if (ID == 2)
            {
                this.link.currentProjectile = new FireballProjectile(itemPosition, 90);
            }
            else if (ID == 3)
            {
                this.link.currentProjectile = new MagicBoomerangProjectile(itemPosition, 90);
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
