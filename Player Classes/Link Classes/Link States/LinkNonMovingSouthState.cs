using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingSouthState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingSouthState(Link link)
        {
            this.link = link;
            //Texture2D sprite = ThisGame.Content.Load<Texture2D>("Link");
            //ThisGame.SetSprite(new NonMovingSouthSprite(sprite, new Vector2(320, 200)));

        }
        public void South()
        {
            link.state = new LinkMovingSouthState(link);
        }
        public void North()
        {
            link.state = new LinkNonMovingNorthState(link);
        }
        public void East()
        {
            link.state = new LinkNonMovingEastState(link);
        }
        public void West()
        {
            link.state = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.state = new LinkDamagedNonMovingSouthState(link);
        }
        public void UseItem()
        {
            link.state = new LinkUseItemSouthState(link);
        }
        public void UseSword()
        {
            link.state = new LinkSwordSouthState(link);
        }
        public void Update()
        {
            // no action
        }




    }
}
