using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    interface ILevel
    {
        void Initialize();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
