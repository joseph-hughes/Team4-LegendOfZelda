using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkNonMovingSouthState : IState
    {
        private Link link;
        public LegendOfZelda ThisGame { get; set; }
        public LinkNonMovingSouthState(Link link)
        {
            this.link = link;
            //Texture2D sprite = ThisGame.Content.Load<Texture2D>("Link");
            //ThisGame.SetSprite(new NonMovingSouthSprite(sprite, new Vector2(320, 200)));

        }
        public void GoSouth()
        {
            link.State = new LinkMovingSouthState(link);
        }
        public void GoNorth()
        {
            link.State = new LinkNonMovingNorthState(link);
        }
        public void GoEast()
        {
            link.State = new LinkNonMovingEastState(link);
        }
        public void GoWest()
        {
            link.State = new LinkNonMovingWestState(link);
        }
        public void BeDamaged()
        {
            link.State = new LinkDamagedNonMovingSouthState(link);
        }
        public void UseItem()
        {
            link.State = new LinkUseItemSouthState(link);
        }
        public void Attack()
        {
            link.State = new LinkSwordSouthState(link);
        }
        public void Update()
        {
            // no action
        }




    }
}
