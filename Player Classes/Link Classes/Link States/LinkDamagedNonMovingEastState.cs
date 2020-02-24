using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingEastState : IState
    {
        private Link link;
        private int timer;

        public LinkDamagedNonMovingEastState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedNonMovingEastSprite();
        }

        public void North()
        {
            link.State = new LinkDamagedNonMovingNorthState(link, timer);
        }

        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link, timer);
        }

        public void South()
        {
            link.State = new LinkDamagedNonMovingSouthState(link, timer);
        }

        public void West()
        {
            link.State = new LinkDamagedNonMovingWestState(link, timer);
        }

        public void Idle()
        {
            // Do nothing
        }

        public void BeDamaged()
        {
            // Do nothing
        }

        public void UseItem()
        {
            // Do nothing
        }

        public void Attack()
        {
            // Do nothing
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
