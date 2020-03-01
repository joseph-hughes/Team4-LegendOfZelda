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
        public Rectangle Rectangle { get; set; }
        public float Scale { get; set; }
        public int currentUseItemID { get; set; }
        public IProjectile currentProjectile { get; set; }
        public int attackDirection { get; set; } // 0 for north, clockwise, -1 for no action
        public bool isDamaged { get; set; }
        public const int damage_timer = 80;
        public const int use_item_timer = 20;
        public const int sword_timer = 20;
        public const int knockback_distance = 80;
        public const int knockback_timer = 5;

        public IItem currentItem { get; set; }
        public Link(Vector2 position)
        {
            Position = position;
            Scale = 3f;
            attackDirection = -1;
            isDamaged = false;
            State = new LinkNonMovingSouthState(this);
            Position = position;
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
            Sprite.Draw(spriteBatch, Rectangle);
        }
    }
}
