using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public interface IItem
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
        void UseItem(Vector2 location);
    }
}
