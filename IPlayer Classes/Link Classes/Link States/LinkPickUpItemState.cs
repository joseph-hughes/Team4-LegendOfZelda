using Microsoft.Xna.Framework;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IState_Classes
{
    class LinkPickUpItemState : IState
    {
        private Link link;
        private IItem item; 
        private int timer;
        private IRoom room;


        public LinkPickUpItemState(Link link, int timer, IItem item, IRoom room)
        {
            this.link = link;
            this.timer = timer;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Direction = Vector.Orientation.West;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = true;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreateLinkPickUpItemSprite();
            this.item = item;
            this.room = room;

            SFXFactory.Instance.PlayItemReceived();
          


        }
        public void South()
        {
            // no action
        }
        public void North()
        {
            // no action
        }
        public void East()
        {
            // no action
        }
        public void West()
        {
            // no action
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
            // no action
        }
        public void Attack()
        {
            // no action
        }
        public void Update()
        {
            item.Update(new Rectangle(link.DestinationRectangle.X+5, link.DestinationRectangle.Y - item.DestinationRectangle.Width-30, item.DestinationRectangle.Width, item.DestinationRectangle.Height));
            this.timer -= 1;
            if (this.timer == 0)
            {
                room.ReceivedItems.Remove(item);
                link.State = new LinkNonMovingSouthState(link);
            }
        }
    }
}
