using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public interface IItem
    {
        Vector2 itemLocation { get; set; }
        Rectangle Rectangle { get; set; }
        float Scale { get; set; }
        void Draw(SpriteBatch spriteBatch);
        void Update();
        void UseItem();
    }
}
