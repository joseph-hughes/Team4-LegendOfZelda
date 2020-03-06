using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public interface ISprite
    {
        Rectangle SourceRectangle { get; set; }

        void Update();
        void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle);
    }
}
