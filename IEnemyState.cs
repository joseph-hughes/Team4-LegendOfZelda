using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    interface IEnemyState
    {
        void GoLeft();
        void GoRight();
        void GoUp();
        void GoDown();
        void Attack();
        void BeHit();
    }
}
