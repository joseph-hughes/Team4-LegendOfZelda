using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingWestState : IState
    {
        private Link link;
        
        public LinkMovingWestState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingWestSprite();
        }

        public void North()
        {
            link.State = new LinkNonMovingNorthState(link);
        }

        public void East()
        {
            link.State = new LinkNonMovingEastState(link);
        }

        public void South()
        {
            link.State = new LinkNonMovingSouthState(link);
        }

        public void West()
        {
            // Do nothing
        }

        public void Idle()
        {
            link.State = new LinkNonMovingWestState(link);
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
            link.Position = new Vector2(link.Position.X - 2, link.Position.Y);
        }
    }
}
