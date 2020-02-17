using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public interface ILevel
    {
        void Initialize();
        void Update();
        void Draw(SpriteBatch spriteBatch);
        void NextItem();
        void PreviousEnemy();
        void PreviousItem();
        void NextEnemy();
    }
}
