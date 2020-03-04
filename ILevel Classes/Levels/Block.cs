using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class Block : IBlock
    {
        public Rectangle Rectangle { get; set; }
        public Block(Rectangle Rectangle)
        {
            this.Rectangle = Rectangle;
        }
    }
}
