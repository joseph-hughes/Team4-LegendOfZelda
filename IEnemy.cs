using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public interface IEnemy
    {
        ISprite Sprite { get; set; }
        IState State { get; set; }
        Vector2 Position { get; set; }
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
