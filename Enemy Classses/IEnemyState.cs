using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    interface IEnemyState : IState
    {
        void GoLeft();
        void GoRight();
        void GoUp();
        void GoDown();
        void Attack();
        void BeHit();
    }
}
