namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkDamagedNonMovingSouthState : IState
    {
        private Link link;
        private int timer;

        public LegendOfZelda ThisGame { get; set; }
        public LinkDamagedNonMovingSouthState(Link link, int timer)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Direction = Vector.Orientation.South;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = true;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkDamagedNonMovingSouthSprite();
        }
        public void South()
        {
            link.State = new LinkDamagedMovingSouthState(link, timer);
        }
        public void North()
        {
            link.State = new LinkDamagedMovingNorthState(link, timer);
        }
        public void East()
        {
            link.State = new LinkDamagedMovingEastState(link, timer);
        }
        public void West()
        {
            link.State = new LinkDamagedMovingWestState(link, timer);
        }
        public void Freeze()
        {
            // Do nothing
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
                link.State = new LinkNonMovingSouthState(link);
                link.IsDamaged = false;
            }
        }
    }
}
