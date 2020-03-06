using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class Map : IMap
    {
        public Rectangle DestinationRectangle { get; set; }
        public ISprite MapSprite { get; set; }

        public Map()
        {
            // FIX
            MapSprite = MapAndHUDSpriteFactory.Instance.CreateEmptyRoomSprite();
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

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            MapSprite.Draw(spriteBatch, DestinationRectangle);
        }
    }
}
