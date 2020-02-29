using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemNorthState : IState
    {
        private Link link;
        private int timer;
        private int ID;

   
        public LinkUseItemNorthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkUseItemNorthSprite();
            this.ID = link.currentUseItemID;
            Vector2 position = new Vector2(link.Position.X + 20, link.Position.Y + 20);

            if (ID == 0)
            {
                this.link.currentProjectile = new ArrowProjectile(position, 0);
            }
            else if (ID == 1)
            {
                this.link.currentProjectile = new BoomerangProjectile(position, 0);
            }
            else if (ID == 2)
            {
                this.link.currentProjectile = new FireballProjectile(position, 0);
            }
            else if (ID == 3)
            {
                this.link.currentProjectile = new MagicBoomerangProjectile(position, 0);
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
                link.State = new LinkNonMovingNorthState(link);
        }
    }
}
