using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class Block : IBlock
    {
        public Rectangle DestinationRectangle { get; set; }
        public bool CanBeMoved { get; set; }
        public List<Vector.Orientation> OptionalDirection { get; set; }
        public ISprite BlockSprite { get; set; }
        public Block(bool CanBeMoved, Rectangle DestinationRectangle, ISprite Sprite)
        {
            this.CanBeMoved = CanBeMoved;
            if (CanBeMoved)
            {
                OptionalDirection = new List<Vector.Orientation> { Vector.Orientation.North, Vector.Orientation.East, Vector.Orientation.South, Vector.Orientation.West };
            }
            this.DestinationRectangle = DestinationRectangle;
            BlockSprite = Sprite;


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            BlockSprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
