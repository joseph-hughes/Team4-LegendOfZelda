﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingSouthState : IState
    {
        private Link link;

        public LinkMovingSouthState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingSouthSprite();
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
            // Do nothing
        }

        public void West()
        {
            link.State = new LinkMovingWestState(link);
        }

        public void Idle()
        {
            link.State = new LinkNonMovingSouthState(link);
        }

        public void BeDamaged()
        {
            int dtimer = 10;
            link.State = new LinkDamagedMovingSouthState(link, dtimer);
        }

        public void UseItem()
        {
            int utimer = 4;
            link.State = new LinkUseItemSouthState(link, utimer);
        }

        public void Attack()
        {
            int stimer = 4;
            link.State = new LinkSwordSouthState(link, stimer);
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y + 2);
        }
    }
}
