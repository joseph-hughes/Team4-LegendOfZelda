using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class NonMovingSouthLinkState : IPlayerState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public NonMovingSouthLinkState(Link link)
        {
            this.link = link;
            //Texture2D sprite = ThisGame.Content.Load<Texture2D>("Link");
            //ThisGame.SetSprite(new NonMovingSouthSprite(sprite, new Vector2(320, 200)));

        }
        public void South()
        {
            link.state = new MovingSouthLinkState(link);
        }
        public void North()
        {
            link.state = new NonMovingNorthLinkState(link);
        }
        public void East()
        {
            link.state = new NonMovingEastLinkState(link);
        }
        public void West()
        {
            link.state = new NonMovingWestLinkState(link);
        }
        public void BeDamaged()
        {
            link.state = new DamagedNonMovingSouthLinkState(link);
        }
        public void UseItem()
        {
            link.state = new UseItemSouthLinkState(link);
        }
        public void UseSword()
        {
            link.state = new SwordSouthLinkState(link);
        }
        public void Update()
        {
            // no action
        }




    }
}
