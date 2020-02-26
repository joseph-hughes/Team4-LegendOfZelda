﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkUseItemSouthState : IState
    {
        private Link link;
        private int timer;
        private int ID;


        public LinkUseItemSouthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkUseItemSouthSprite(); 
            this.ID = link.currentUseItemID;
            if (ID == 0)
            {
                this.link.currentProjectile = new ArrowProjectile(link.Position, 180);
            }
            else if (ID == 1)
            {
                this.link.currentProjectile = new BoomerangProjectile(link.Position, 180);
            }
            else if (ID == 2)
            {
                this.link.currentProjectile = new FireballProjectile(link.Position, 180);
            }
            else if (ID == 3)
            {
                this.link.currentProjectile = new MagicBoomerangProjectile(link.Position, 180);
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
            link.State = new LinkKnockbackSouthState(link, Link.knockback_timer);
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
                link.State = new LinkNonMovingSouthState(link);
        }
    }
}
