using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class Map : IMap
    {
        public Rectangle DestinationRectangle { get; set; }
        public ISprite MapSprite { get; set; }
        const int ROOM_WIDTH = 256, ROOM_HEIGHT = 176;

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
            int newRoomY = MapSprite.SourceRectangle.Y - ROOM_HEIGHT;
            MapSprite.SourceRectangle = new Rectangle(MapSprite.SourceRectangle.X, newRoomY, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
        }

        public void East()
        {
            int newRoomX = MapSprite.SourceRectangle.X + ROOM_WIDTH;
            MapSprite.SourceRectangle = new Rectangle(newRoomX, MapSprite.SourceRectangle.Y, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
        }

        public void South()
        {
            int newRoomY = MapSprite.SourceRectangle.Y + ROOM_HEIGHT;
            MapSprite.SourceRectangle = new Rectangle(MapSprite.SourceRectangle.X, newRoomY, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
        }

        public void West()
        {
            int newRoomX = MapSprite.SourceRectangle.X - ROOM_WIDTH;
            MapSprite.SourceRectangle = new Rectangle(newRoomX, MapSprite.SourceRectangle.Y, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
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
