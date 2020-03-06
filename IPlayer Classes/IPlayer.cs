using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public interface IPlayer
    {
        ISprite Sprite { get; set; }
        IState State { get; set; }
        Vector2 Position { get; set; }
        Rectangle DestinationRectangle { get; set; }
        Rectangle LinkSwordRectangle { get; set; }
        float Scale { get; set; }
        Vector2 itemPosition { get; set; }
        int Direction { get; set; }
        int Velocity { get; set; }
        bool isAttacking { get; set; }
        bool isKnocked { get; set; }
        bool isDamaged { get; set; }
        void North();
        void East();
        void South();
        void West();
        void Idle();
        void BeDamaged();
        void UseItem();
        void Attack();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}