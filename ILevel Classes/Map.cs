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

        }

        public void Initialize(int mapXPosition, int mapYPosition, int mapWidth, int mapHeight)
        {

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
