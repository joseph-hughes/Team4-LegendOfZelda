using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    interface IEnemy
    {
        ISprite Sprite { get; set; }
        IEnemyState State { get; set; }
        Vector2 Position { get; set; }
        void GoLeft();
        void GoRight();
        void GoUp();
        void GoDown();
        void Attack();
        void BeHit();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
