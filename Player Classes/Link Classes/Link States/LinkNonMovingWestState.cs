﻿using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingWestState : IState
    {
        private Link link;
        
        public LinkNonMovingWestState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkNonMovingWestSprite();
        }

        public void North()
        {
            link.State = new LinkMovingNorthState(link);
        }

        public void East()
        {
            link.State = new LinkMovingEastState(link);
        }

        public void South()
        {
            link.State = new LinkMovingSouthState(link);
        }

        public void West()
        {
            link.State = new LinkMovingWestState(link);
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            int dtimer = 10;
            link.State = new LinkDamagedMovingWestState(link, dtimer);
        }

        public void UseItem()
        {
            int utimer = 4;
            link.State = new LinkUseItemWestState(link, utimer);
        }

        public void Attack()
        {
            int stimer = 4;
            link.State = new LinkSwordWestState(link, stimer);
        }

        public void Update()
        {
            // no action
        }
    }
}
