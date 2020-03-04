using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
    public class MapSpriteFactory : ISpriteFactory
    {
        private Texture2D sprint2MapTexture;
        //private Texture2D level1MapTexture;
        // All other level map textures

        private static MapSpriteFactory instance = new MapSpriteFactory();

        public static MapSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private MapSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            sprint2MapTexture = content.Load<Texture2D>("MapSprites/emptyroom");
        }

        // Old Man Sprites
        public ISprite CreateSprint2MapSprite()
        {
            return new TextureSprite(sprint2MapTexture);
        }
    }
}
