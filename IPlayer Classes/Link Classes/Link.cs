using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IState_Classes;
using Team4_LegendOfZelda.Vector;

namespace Team4_LegendOfZelda
{
    public class Link : IPlayer
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public Rectangle LinkSwordRectangle { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public float Scale { get; set; }
        public Vector2 ItemPosition { get; set; }
        public IVector Velocity { get; set; }
        public IItem CurrentItem { get; set; }
        public bool IsAttacking { get; set; }
        public bool IsKnocked { get; set; }
        public bool IsDamaged { get; set; }
        public bool IsDeath { get; set; }

        public const int DAMAGE_TIMER = 80;
        public const int USE_ITEM_TIMER = 20;
        public const int SWORD_TIMER = 20;
        public const int KNOCKBACK_TIMER = 10;
        public const int LINK_WIDTH = 16;
        public const int LINK_HEIGHT = 16;

        public Link(Vector2 position)
        {
            Scale = 3f;
            Velocity = new VelocityVector(0, Orientation.South);
            State = new LinkNonMovingSouthState(this);
            DestinationRectangle = new Rectangle((int)position.X, (int)position.Y, (int)(Scale * LINK_WIDTH), (int)(Scale * LINK_HEIGHT));

            CurrentHitPoints = 6;
            MaxHitPoints = 6;

        }

        public void North()
        {
            State.North();
        }

        public void East()
        {
            State.East();
        }

        public void South()
        {
            State.South();
        }

        public void West()
        {
            State.West();
        }

        public void Idle()
        {
            State.Idle();
        }

        public void BeDamaged()
        {
            if (CurrentHitPoints > 0)
            {
                CurrentHitPoints--;
                State.BeDamaged();
            }
            else
            {
                // Link dies
                State.BeDamaged(); //temp
            }
        }

        public void UseItem()
        {
            State.UseItem();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void Update()
        {
            Sprite.Update();
            State.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (!IsAttacking)
            {
                Sprite.Draw(spriteBatch, DestinationRectangle);
            }
            else
            {
                Sprite.Draw(spriteBatch, LinkSwordRectangle);
            }

        }
    }
}
