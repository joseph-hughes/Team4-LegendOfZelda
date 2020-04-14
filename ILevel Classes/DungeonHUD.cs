using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class DungeonHUD : IHUD
    {
        public ILevel Level { get; set; }
        public ISprite HUDSprite { get; set; }
        public Rectangle HUDDestinationRectangle { get; set; }
        public ISprite MinimapSprite { get; set; }
        public Rectangle MinimapDestinationRectangle { get; set; }
        public List<ISprite> HeartSprites { get; set; }
        public List<int> HeartValues { get; set; }  // 0 = empty, 1 = half, 2 = full
        public List<Rectangle> HeartDestinationRectangles { get; set; }
        public int CurrentPlayerHitPoints { get; set; }

        private ISprite levelNumSprite;
        private Rectangle levelNumDestinationRectangle;

        private const int STD_HUD_X = 0, STD_HUD_Y = 0, STD_HUD_WIDTH = 256, STD_HUD_HEIGHT = 56;
        private const int STD_MINIMAP_X = 16, STD_MINIMAP_Y = 16, STD_MINIMAP_WIDTH = 64, STD_MINIMAP_HEIGHT = 32;
        private const int STD_LEVEL_NUM_X = 64, STD_LEVEL_NUM_Y = 8, STD_LEVEL_NUM_WIDTH = 8, STD_LEVEL_NUM_HEIGHT = 8;
        private const int STD_HEART_1_X = 176, STD_HEART_1_Y = 40, STD_HEART_WIDTH = 8, STD_HEART_HEIGHT = 8;
        private const int STD_HEART_COLUMNS = 8, STD_HEART_ROWS = 2;

        public DungeonHUD(ILevel level, int levelNum)
        {
            Level = level;
            HUDSprite = MapAndHUDSpriteFactory.Instance.CreateHudSprite();

            switch (levelNum)
            {
                case 1:
                    levelNumSprite = MapAndHUDSpriteFactory.Instance.CreateNumber1Sprite();
                    MinimapSprite = MapAndHUDSpriteFactory.Instance.CreateLevel1MinimapSprite();
                    break;
                default:
                    levelNumSprite = MapAndHUDSpriteFactory.Instance.CreateNumber0Sprite();
                    MinimapSprite = MapAndHUDSpriteFactory.Instance.CreateLevel1MinimapSprite();
                    break;
            }

            HeartSprites = new List<ISprite>();
            HeartDestinationRectangles = new List<Rectangle>();
            HeartValues = new List<int>();
            CurrentPlayerHitPoints = 0;
        }

        public void Initialize(int hudXPosition, int hudYPosition, int hudWidth, int hudHeight)
        {
            HUDDestinationRectangle = new Rectangle(hudXPosition, hudYPosition, hudWidth, hudHeight);
            int hudXOffset = hudXPosition - STD_HUD_X;
            int hudYOffset = hudYPosition - STD_HUD_Y;
            double hudWidthRatio = (double)hudWidth / STD_HUD_WIDTH;
            double hudHeightRatio = (double)hudHeight / STD_HUD_HEIGHT;

            levelNumDestinationRectangle = new Rectangle(
                (int)((STD_LEVEL_NUM_X + hudXOffset) * hudWidthRatio),
                (int)((STD_LEVEL_NUM_Y + hudYOffset) * hudHeightRatio),
                (int)(STD_LEVEL_NUM_WIDTH * hudWidthRatio),
                (int)(STD_LEVEL_NUM_HEIGHT * hudHeightRatio)
                );

            MinimapDestinationRectangle = new Rectangle(
                (int)((STD_MINIMAP_X + hudXOffset) * hudWidthRatio),
                (int)((STD_MINIMAP_Y + hudYOffset) * hudHeightRatio),
                (int)(STD_MINIMAP_WIDTH * hudWidthRatio),
                (int)(STD_MINIMAP_HEIGHT * hudHeightRatio)
                );

            int maxHearts = STD_HEART_COLUMNS * STD_HEART_ROWS;
            int heartRow = 0;
            int heartColumn = 0;
            for (int index = 0; index < maxHearts; index++)
            {
                HeartValues.Add(0);
                HeartDestinationRectangles.Add(new Rectangle(
                    (int)((STD_HEART_1_X + (heartColumn * STD_HEART_WIDTH) + hudXOffset) * hudWidthRatio),
                    (int)((STD_HEART_1_Y - (heartRow * STD_HEART_HEIGHT) + hudYOffset) * hudHeightRatio),
                    (int)(STD_HEART_WIDTH * hudWidthRatio),
                    (int)(STD_HEART_HEIGHT * hudHeightRatio)
                    ));

                if (heartColumn == STD_HEART_COLUMNS - 1)
                {
                    heartColumn = 0;
                    heartRow++; // This should never exceed the number of rows
                }
                else
                {
                    heartColumn++;
                }
            }
        }

        public void Update()
        {
            List<int> newHeartValues = new List<int>();
            for (int index = 0; index < HeartValues.Count; index++)
            {
                newHeartValues.Add(HeartValues[index]);
            }

            if (Level.Player.MaxHitPoints != (HeartSprites.Count * 2) - (Level.Player.MaxHitPoints % 2))
            {
                if (Level.Player.MaxHitPoints > (HeartSprites.Count * 2))
                {
                    int newNumHearts = (Level.Player.MaxHitPoints / 2) + (Level.Player.MaxHitPoints % 2);
                    while (HeartSprites.Count < newNumHearts)
                    {
                        HeartSprites.Add(MapAndHUDSpriteFactory.Instance.CreateFullHeartSprite());
                        HeartValues[HeartSprites.Count - 1] = 2;
                    }
                }
                else
                {
                    // The total hearts should never decrease during a level
                    while (HeartSprites.Count > (Level.Player.MaxHitPoints / 2))
                    {
                        HeartSprites.RemoveAt(HeartSprites.Count - 1);
                    }
                }
            }

            if (Level.Player.CurrentHitPoints != CurrentPlayerHitPoints)
            {
                int tempHitPoints = Level.Player.CurrentHitPoints;
                int index = 0;
                while (index < newHeartValues.Count)
                {
                    if (tempHitPoints == 1)
                    {
                        newHeartValues[index] = 1;
                        tempHitPoints--;
                    }
                    else if (tempHitPoints == 0)
                    {
                        newHeartValues[index] = 0;
                    }
                    else
                    {
                        newHeartValues[index] = 2;
                        tempHitPoints -= 2;
                    }
                    index++;
                }
                CurrentPlayerHitPoints = Level.Player.CurrentHitPoints;
            }

            for (int index = 0; index < HeartSprites.Count; index++)
            {
                if (newHeartValues[index] != HeartValues[index])
                {
                    switch (newHeartValues[index])
                    {
                        case 0:
                            HeartSprites[index] = MapAndHUDSpriteFactory.Instance.CreateEmptyHeartSprite();
                            break;
                        case 1:
                            HeartSprites[index] = MapAndHUDSpriteFactory.Instance.CreateHalfHeartSprite();
                            break;
                        case 2:
                            HeartSprites[index] = MapAndHUDSpriteFactory.Instance.CreateFullHeartSprite();
                            break;
                        default:
                            // This should never happen, but will have the case for full heart
                            HeartSprites[index] = MapAndHUDSpriteFactory.Instance.CreateFullHeartSprite();
                            break;
                    }
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            HUDSprite.Draw(spriteBatch, HUDDestinationRectangle);
            levelNumSprite.Draw(spriteBatch, levelNumDestinationRectangle);
            MinimapSprite.Draw(spriteBatch, MinimapDestinationRectangle);
            for (int index = 0; index < HeartSprites.Count; index++)
            {
                HeartSprites[index].Draw(spriteBatch, HeartDestinationRectangles[index]);
            }
        }
    }
}
