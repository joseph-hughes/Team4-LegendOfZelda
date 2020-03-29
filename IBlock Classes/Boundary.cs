using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda.IBlock_Classes
{
    class Boundary: IBlock
    {
        public Rectangle DestinationRectangle { get; set; }
        public Boundary(Rectangle DestinationRectangle)
        {
            this.DestinationRectangle = DestinationRectangle;
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
