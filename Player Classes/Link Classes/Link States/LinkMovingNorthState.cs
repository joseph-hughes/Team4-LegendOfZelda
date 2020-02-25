using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkMovingNorthState : IState
    {
        private Link link;

        public LinkMovingNorthState(Link link)
        {
            this.link = link;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkMovingNorthSprite();
        }

        public void North()
        {
            // Do nothing
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
            link.State = new LinkNonMovingNorthState(link);
        }

        public void BeDamaged()
        {
            int dtimer = 10;
            link.State = new LinkDamagedMovingNorthState(link, dtimer);
        }

        public void UseItem()
        {
            int utimer = 4;
            link.State = new LinkUseItemNorthState(link, utimer);
        }

        public void Attack()
        {
            int stimer = 4;
            link.State = new LinkSwordNorthState(link, stimer);
        }

        public void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y - 2);
        }
    }
}
