using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    public interface IBlock
    {
        Rectangle DestinationRectangle { get; set; }
        bool CanBeMoved { get; set; }
        List<Vector.Orientation> OptionalDirecton { get; set; }
        ISprite BlockSprite { get; set; }
        void Draw(SpriteBatch spriteBatch);
    }
}
