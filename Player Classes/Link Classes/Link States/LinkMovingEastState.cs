using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingEastState : IState
    {
        private Link link;

        public LinkMovingEastState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingEastSprite();
        }

        public void North()
        {
            link.State = new LinkMovingNorthState(link);
        }

        public void East()
        {
            // Do nothing
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
            link.State = new LinkNonMovingEastState(link);
        }

        public void BeDamaged()
        {
            int dtimer = 10;
            link.State = new LinkDamagedMovingEastState(link, dtimer);
        }

        public void UseItem()
        {
            int utimer = 4;
            link.State = new LinkUseItemEastState(link, utimer);
        }

        public void Attack()
        {
            int stimer = 4;
            link.State = new LinkSwordEastState(link, stimer);
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X + 2, link.Position.Y);
        }
    }
}
