using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class NonmoveableBlock : IBlock
    {
        public Rectangle DestinationRectangle { get; set; }
        public NonmoveableBlock(Rectangle DestinationRectangle)
        {
            this.DestinationRectangle = DestinationRectangle;
        }
        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
