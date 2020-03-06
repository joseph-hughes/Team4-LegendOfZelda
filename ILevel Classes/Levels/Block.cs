using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class Block : IBlock
    {
        public Rectangle DestinationRectangle { get; set; }
        public Block(Rectangle DestinationRectangle)
        {
            this.DestinationRectangle = DestinationRectangle;
        }
    }
}
