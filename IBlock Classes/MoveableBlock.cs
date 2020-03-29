using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class MoveableBlock : IBlock
    {
        public Rectangle DestinationRectangle { get; set; }
        ISprite BlockSprite;
        public MoveableBlock(Rectangle DestinationRectangle)
        {
            this.DestinationRectangle = DestinationRectangle;
            BlockSprite = MapAndHUDSpriteFactory.Instance.CreateSingleBlockSprite();

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            BlockSprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
