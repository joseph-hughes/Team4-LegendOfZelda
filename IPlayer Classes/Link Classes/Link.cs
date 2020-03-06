using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.IState_Classes;

namespace Team4_LegendOfZelda
{
    public class Link : IPlayer
    {
        public ISprite Sprite { get; set; }
        public IState State { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public Rectangle LinkSwordRectangle { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public float Scale { get; set; }
        public Vector2 itemPosition { get; set; }
        public int Direction { get; set; } // 0 for north, clockwise
        public int Velocity { get; set; }
        public bool isAttacking { get; set; }
        public bool isKnocked { get; set; }
        public bool isDamaged { get; set; }
        public const int damage_timer = 80;
        public const int use_item_timer = 20;
        public const int sword_timer = 20;
        public const int knockback_timer = 10;
        public const int linkWidth = 16;
        public const int linkHeight = 16;

        public IItem currentItem { get; set; }
        public Link(Vector2 position)
        {
            Position = position;
            Scale = 3f;
            State = new LinkNonMovingSouthState(this);

            DestinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, (int)(Scale * linkWidth), (int)(Scale * linkHeight));

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
            State.BeDamaged();
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
            if (!isAttacking)
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
