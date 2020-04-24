using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class Map : IMap
    {
        public Rectangle DestinationRectangle { get; set; }
        public ISprite MapSprite { get; set; }

        public Map(int levelNum)
        {
            switch (levelNum)
            {
                case 0:
                    // Overworld
                    break;
                case 1:
                    MapSprite = MapAndHUDSpriteFactory.Instance.CreateLevel1MapSprite();
                    break;
                default:
                    MapSprite = MapAndHUDSpriteFactory.Instance.CreateEmptyRoomSprite();
                    break;
            }
        }

        public void Initialize(int mapXPosition, int mapYPosition, int mapWidth, int mapHeight)
        {
            DestinationRectangle = new Rectangle(mapXPosition, mapYPosition, mapWidth, mapHeight);
        }

        public void North()
        {
            // Transition to room north of current room
        }

        public void East()
        {
            // Transition to room north of current room
        }

        public void South()
        {
            // Transition to room north of current room
        }

        public void West()
        {
            // Transition to room north of current room
        }

        public void Other()
        {
            // Transition to current room's other room, if it exists
        }

        public void Update()
        {
            // TODO?
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            MapSprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
