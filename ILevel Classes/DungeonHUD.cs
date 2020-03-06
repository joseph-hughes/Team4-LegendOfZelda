using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class DungeonHUD : IHUD
    {
        public ILevel Level { get; set; }
        public Rectangle DestinationRectangle { get; set; }
        public ISprite HUDSprite { get; set; }
        public ISprite LevelNumSprite { get; set; }
        public ISprite LevelMinimapSprite { get; set; }

        public DungeonHUD(ILevel level, int levelNum)
        {
            Level = level;
            HUDSprite = MapAndHUDSpriteFactory.Instance.CreateHudSprite();
            switch (levelNum)
            {
                case 1:
                    LevelNumSprite = MapAndHUDSpriteFactory.Instance.CreateNumber1Sprite();
                    break;
                default:
                    LevelNumSprite = MapAndHUDSpriteFactory.Instance.CreateNumber0Sprite();
                    break;
            }
        }

        public void Initialize(int hudXPosition, int hudYPosition, int hudWidth, int hudHeight)
        {
            DestinationRectangle = new Rectangle(hudXPosition, hudYPosition, hudWidth, hudHeight);
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
