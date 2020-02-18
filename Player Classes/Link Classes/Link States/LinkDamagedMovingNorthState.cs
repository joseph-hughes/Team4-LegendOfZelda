using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedMovingNorthState : IState
    {
        private Link link;
        private int timer;

        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedMovingNorthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedMovingNorthSprite();
        }
        public void South()
        {
            link.State = new LinkDamagedNonMovingSouthState(link, timer);
        }
        public void North()
        {
            // no action 
        }
        public void East()
        {
            link.State = new LinkDamagedNonMovingEastState(link, timer);
        }
        public void West()
        {
            link.State = new LinkDamagedNonMovingWestState(link, timer);
        }
        public void BeDamaged()
        {
            // no action
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
            if (link.Position.Y > 0)
            {
                link.Position = new Vector2(link.Position.X, link.Position.Y - 1);
            }

            this.timer -= 1;
            if (this.timer == 0)
            {
                link.State = new LinkMovingNorthState(link);
            }
        }
    }
}
