using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
    public class MapAndHUDSpriteFactory : ISpriteFactory
    {
        private Texture2D hudTexture;
        private Texture2D emptyRoomTexture;
        //private Texture2D number0Texture;
        //private Texture2D number1Texture;
        //private Texture2D number2Texture;
        //private Texture2D number3Texture;
        //private Texture2D number4Texture;
        //private Texture2D number5Texture;
        //private Texture2D number6Texture;
        //private Texture2D number7Texture;
        //private Texture2D number8Texture;
        //private Texture2D number9Texture;
        //private Texture2D emptyHeartTexture;
        //private Texture2D halfHeartTexture;
        //private Texture2D fullHeartTexture;

        private Texture2D level1MapTexture;
        //private Texture2D level1MinimapTexture;

        private static MapAndHUDSpriteFactory instance = new MapAndHUDSpriteFactory();

        public static MapAndHUDSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private MapAndHUDSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            emptyRoomTexture = content.Load<Texture2D>("MapSprites/emptyroom");
            hudTexture = content.Load<Texture2D>("MapSprites/");
            //number0Texture = content.Load<Texture2D>("MapSprites/");

            level1MapTexture = content.Load<Texture2D>("MapSprites/fullmap");
            //level1MinimapTexture = content.Load<Texture2D>("MapSprites/");
        }

        public ISprite CreateEmptyRoomSprite()
        {
            return new TextureSprite(emptyRoomTexture);
        }

        // Level 1 Sprites
        public ISprite CreateLevel1MapSprite()
        {
            return new TextureSprite(level1MapTexture);
        }

        //public ISprite CreateLevel1MinimapSprite()
        //{
        //    return new TextureSprite(level1MinimapTexture);
        //}
    }
}
