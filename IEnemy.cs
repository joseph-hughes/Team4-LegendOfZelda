using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    interface IEnemy
    {
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
