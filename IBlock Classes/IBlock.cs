using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IBlock
    {
        Rectangle DestinationRectangle { get; set; }
        void Draw(SpriteBatch spriteBatch);
    }
}
