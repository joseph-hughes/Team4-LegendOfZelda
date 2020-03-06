using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class DungeonHUD : IHUD
    {
        public Rectangle DestinationRectangle { get; set; }
        public ISprite HUDSprite { get; set; }
        public ILevel Level { get; set; }

        public DungeonHUD(ILevel level)
        {
            Level = level;
        }

        public void Initialize(int hudXPosition, int hudYPosition, int hudWidth, int hudHeight)
        {

        }

        public void Update()
        {
            // Look at level values and possibly change what is on the hud
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            HUDSprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
