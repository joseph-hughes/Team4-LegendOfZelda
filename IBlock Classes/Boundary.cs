using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IBlock_Classes
{
    class Boundary : IBlock
    {
        public Rectangle DestinationRectangle { get; set; }
        public bool CanBeMoved { get; set; }
        public List<Vector.Orientation> OptionalDirection { get; set; }
        public ISprite BlockSprite { get; set; }

        public Boundary(Rectangle DestinationRectangle)
        {
            CanBeMoved = false;
            this.DestinationRectangle = DestinationRectangle;
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
