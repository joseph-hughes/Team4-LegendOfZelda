using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
{
    public interface Iitem
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
        void UseItem();
    }
}
