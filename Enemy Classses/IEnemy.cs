using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    interface IEnemy
    {
        ISprite Sprite { get; set; }
        IState State { get; set; }
        Vector2 Position { get; set; }
        void South();
        void North();
        void East();
        void West();
        void BeDamaged();
        void Attack();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
