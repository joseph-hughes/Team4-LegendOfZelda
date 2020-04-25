using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.IState_Classes
{
    class PickupItemState : IState
    {
        private Link link;
        private int timer;

        public PickupItemState(Link link)
        {
            this.link = link;
            this.link.Velocity.Magnitude = 0;
            this.link.Velocity.Direction = Vector.Orientation.South;
            this.link.IsAttacking = false;
            this.link.IsKnocked = false;
            this.link.IsDamaged = false;
            this.link.IsDeath = false;
            this.link.Sprite = PlayerSpriteFactory.Instance.CreatePickupItemSprite();
            timer = Link.USE_ITEM_TIMER;
            SFXFactory.Instance.PlayItemRecieved();
        }

        public void North()
        {
            //No action
        }

        public void East()
        {
            //No action
        }

        public void South()
        {
            //No action
        }

        public void West()
        {
            //No action
        }

        public void Idle()
        {
            //No action
        }

        public void BeDamaged()
        {
            //No action
        }

        public void UseItem()
        {
            //No action
        }

        public void Attack()
        {
            //No action
        }

        public void Update()
        {
            timer -= 1;
            if (timer == 0)
            {
                link.State = new LinkNonMovingSouthState(link);
            }
        }
    }
}
