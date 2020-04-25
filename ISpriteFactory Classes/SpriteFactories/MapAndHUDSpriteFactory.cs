using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
    public class MapAndHUDSpriteFactory : ISpriteFactory
    {
        private Texture2D hudTexture;
        private Texture2D emptyRoomTexture;
        private Texture2D number0Texture;
        private Texture2D number1Texture;
        private Texture2D number2Texture;
        private Texture2D number3Texture;
        private Texture2D number4Texture;
        private Texture2D number5Texture;
        private Texture2D number6Texture;
        private Texture2D number7Texture;
        private Texture2D number8Texture;
        private Texture2D number9Texture;
        private Texture2D emptyHeartTexture;
        private Texture2D halfHeartTexture;
        private Texture2D fullHeartTexture;
        private Texture2D itemSelectionScreen;

        private Texture2D level1MapTexture;
        private Texture2D level1MinimapTexture;

        private Texture2D miniMapRedDotTexture;
        private Texture2D miniMapGreenDotTexture;

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
            hudTexture = content.Load<Texture2D>("MapSprites/HUD");
            itemSelectionScreen = content.Load<Texture2D>("MapSprites/Item Selection Screen");

            number0Texture = content.Load<Texture2D>("MapSprites/0");
            number1Texture = content.Load<Texture2D>("MapSprites/1");
            number2Texture = content.Load<Texture2D>("MapSprites/2");
            number3Texture = content.Load<Texture2D>("MapSprites/3");
            number4Texture = content.Load<Texture2D>("MapSprites/4");
            number5Texture = content.Load<Texture2D>("MapSprites/5");
            number6Texture = content.Load<Texture2D>("MapSprites/6");
            number7Texture = content.Load<Texture2D>("MapSprites/7");
            number8Texture = content.Load<Texture2D>("MapSprites/8");
            number9Texture = content.Load<Texture2D>("MapSprites/9");

            emptyHeartTexture = content.Load<Texture2D>("MapSprites/emptyHeart");
            halfHeartTexture = content.Load<Texture2D>("MapSprites/halfHeart");
            fullHeartTexture = content.Load<Texture2D>("MapSprites/fullHeart");


            level1MapTexture = content.Load<Texture2D>("MapSprites/fullmap");
            level1MinimapTexture = content.Load<Texture2D>("MapSprites/level1_minimap");
            miniMapRedDotTexture = content.Load<Texture2D>("MapSprites/minimapReddot");
            miniMapGreenDotTexture = content.Load<Texture2D>("MapSprites/minimapGreendot");

        }

        public ISprite CreateEmptyRoomSprite()
        {
            return new TextureSprite(emptyRoomTexture);
        }

        public ISprite CreateHudSprite()
        {
            return new TextureSprite(hudTexture);
        }
        public ISprite CreateItemSelectionScreen()
        {
            return new TextureSprite(itemSelectionScreen);
        }
        // Level 1 Sprites
        public ISprite CreateLevel1MapSprite()
        {
            return new TextureSprite(level1MapTexture, 6, 6, 2, 5);
        }

        public ISprite CreateLevel1MinimapSprite()
        {
            return new TextureSprite(level1MinimapTexture);
        }

        public ISprite CreateNumber0Sprite()
        {
            return new TextureSprite(number0Texture);
        }

        public ISprite CreateNumber1Sprite()
        {
            return new TextureSprite(number1Texture);
        }

        public ISprite CreateNumber2Sprite()
        {
            return new TextureSprite(number2Texture);
        }

        public ISprite CreateNumber3Sprite()
        {
            return new TextureSprite(number3Texture);
        }

        public ISprite CreateNumber4Sprite()
        {
            return new TextureSprite(number4Texture);
        }

        public ISprite CreateNumber5Sprite()
        {
            return new TextureSprite(number5Texture);
        }

        public ISprite CreateNumber6Sprite()
        {
            return new TextureSprite(number6Texture);
        }


        public ISprite CreateNumber7Sprite()
        {
            return new TextureSprite(number7Texture);
        }

        public ISprite CreateNumber8Sprite()
        {
            return new TextureSprite(number8Texture);
        }

        public ISprite CreateNumber9Sprite()
        {
            return new TextureSprite(number9Texture);
        }

        

        public ISprite CreateEmptyHeartSprite()
        {
            return new TextureSprite(emptyHeartTexture);
        }

        public ISprite CreateHalfHeartSprite()
        {
            return new TextureSprite(halfHeartTexture);
        }

        public ISprite CreateFullHeartSprite()
        {
            return new TextureSprite(fullHeartTexture);
        }

        public ISprite CreateMiniMapGreenDotSprite()
        {
            return new TextureSprite(miniMapGreenDotTexture);
        }

        public ISprite CreateMiniMapRedDotSprite()
        {
            return new TextureSprite(miniMapRedDotTexture);
        }





    }
}
