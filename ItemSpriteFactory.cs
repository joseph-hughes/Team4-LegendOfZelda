using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ISprite_Classes;
using Team4_LegendOfZelda.Item_Classes;

namespace Team4_LegendOfZelda
{
    class ItemSpriteFactory : ISpriteFactory
    {
        private Texture2D secondPotion;
        private Texture2D fiveRupies;
        private Texture2D arrow;
        private Texture2D blueCandle;
        private Texture2D blueRing;
        private Texture2D bomb;
        private Texture2D bookOfMagic;
        private Texture2D boomerang;
        private Texture2D bow;
        private Texture2D clock;
        private Texture2D compass;
        private Texture2D food;
        private Texture2D heartContainer;
        private Texture2D key;
        private Texture2D letter;
        private Texture2D lifePotion;
        private Texture2D magicalBoomerang;
        private Texture2D magicalKey;
        private Texture2D magicalRod;
        private Texture2D magicalShield;
        private Texture2D map;
        private Texture2D powerBracelet;
        private Texture2D raft;
        private Texture2D recorder;
        private Texture2D redCandle;
        private Texture2D redRing;
        private Texture2D silverArrow;
        private Texture2D stepladder;
        private Texture2D sword;
        private Texture2D whiteSword;

        private Texture2D fairy;
        private Texture2D heart;
        private Texture2D rupy;
        private Texture2D triforce;

        private Texture2D EmptyImage;

        private static ItemSpriteFactory instance = new ItemSpriteFactory();

        public static ItemSpriteFactory Instance
        {
            get
            {
                return instance;
            }

        }
        private ItemSpriteFactory()
        {
        }
        public void LoadAllTextures(ContentManager content)
        {
            secondPotion = content.Load<Texture2D>("ItemSprites/2ndPotion");
            fiveRupies = content.Load<Texture2D>("ItemSprites/5Rupies");
            arrow = content.Load<Texture2D>("ItemSprites/5Rupies");
            blueCandle = content.Load<Texture2D>("ItemSprites/BlueCandle");
            blueRing = content.Load<Texture2D>("ItemSprites/BlueRing");
            bomb = content.Load<Texture2D>("ItemSprites/Bomb");
            bookOfMagic = content.Load<Texture2D>("ItemSprites/BookOfMagic");
            boomerang = content.Load<Texture2D>("ItemSprites/Boomerang");
            bow = content.Load<Texture2D>("ItemSprites/Bow");
            clock = content.Load<Texture2D>("ItemSprites/Clock");
            compass = content.Load<Texture2D>("ItemSprites/Compass");
            food = content.Load<Texture2D>("ItemSprites/Food");
            heartContainer = content.Load<Texture2D>("ItemSprites/HeartContainer");
            key = content.Load<Texture2D>("ItemSprites/Key");
            letter = content.Load<Texture2D>("ItemSprites/Letter");
            lifePotion = content.Load<Texture2D>("ItemSprites/LifePotion");
            magicalBoomerang = content.Load<Texture2D>("ItemSprites/MagicalBoomerang");
            magicalKey = content.Load<Texture2D>("ItemSprites/MagicalKey");
            magicalRod = content.Load<Texture2D>("ItemSprites/MagicalRod");
            magicalShield = content.Load<Texture2D>("ItemSprites/MagicalShield");
            map = content.Load<Texture2D>("ItemSprites/Map");
            powerBracelet = content.Load<Texture2D>("ItemSprites/PowerBracelet");
            raft = content.Load<Texture2D>("ItemSprites/Raft");
            recorder = content.Load<Texture2D>("ItemSprites/Recorder");
            redCandle = content.Load<Texture2D>("ItemSprites/RedCandle");
            redRing = content.Load<Texture2D>("ItemSprites/RedRing");
            silverArrow = content.Load<Texture2D>("ItemSprites/SilverArrow");
            stepladder = content.Load<Texture2D>("ItemSprites/Stepladder");
            sword = content.Load<Texture2D>("ItemSprites/Sword");
            whiteSword = content.Load<Texture2D>("ItemSprites/WhiteSword");

            fairy = content.Load<Texture2D>("ItemSprites/AnimatedItems/Fairy");
            heart = content.Load<Texture2D>("ItemSprites/AnimatedItems/Heart");
            rupy = content.Load<Texture2D>("ItemSprites/AnimatedItems/Rupy");
            triforce = content.Load<Texture2D>("ItemSprites/AnimatedItems/Triforce");

            EmptyImage = content.Load<Texture2D>("ItemSprites/EmptyImage");
        }
        //empty item
        public ISprite CreateEmptyItem()
        {
            return new TextureSprite(EmptyImage, 0);
        }
        //non-animated
        public ISprite CreateSecondPotion()
        {
            return new TextureSprite(secondPotion, 3);
        }
        public ISprite CreateFiveRupies()
        {
            return new TextureSprite(fiveRupies, 3);
        }
        public ISprite CreateArrow()
        {
            return new TextureSprite(arrow, 3);
        }
        public ISprite CreateBlueCandle()
        {
            return new TextureSprite(blueCandle, 3);
        }
        public ISprite CreateBlueRing()
        {
            return new TextureSprite(blueRing, 3);
        }
        public ISprite CreateBomb()
        {
            return new TextureSprite(bomb, 3);
        }
        public ISprite CreateBookOfMagic()
        {
            return new TextureSprite(bookOfMagic, 3);
        }
        public ISprite CreateBoomerang()
        {
            return new TextureSprite(boomerang, 3);
        }
        public ISprite CreateBow()
        {
            return new TextureSprite(bow, 3);
        }
        public ISprite CreateClock()
        {
            return new TextureSprite(clock, 3);
        }
        public ISprite CreateCompass()
        {
            return new TextureSprite(compass, 3);
        }
        public ISprite CreateFood()
        {
            return new TextureSprite(food, 3);
        }
        public ISprite CreateHeartContainer()
        {
            return new TextureSprite(heartContainer, 3);
        }
        public ISprite CreateKey()
        {
            return new TextureSprite(key, 3);
        }
        public ISprite CreateLetter()
        {
            return new TextureSprite(letter, 3);
        }
        public ISprite CreateLifePotion()
        {
            return new TextureSprite(lifePotion, 3);
        }
        public ISprite CreateMagicalBoomerang()
        {
            return new TextureSprite(magicalBoomerang, 3);
        }
        public ISprite CreateMagicalKey()
        {
            return new TextureSprite(magicalKey, 3);
        }
        public ISprite CreateMagicalRod()
        {
            return new TextureSprite(magicalRod, 3);
        }
        public ISprite CreateMagicalShield()
        {
            return new TextureSprite(magicalShield, 3);
        }
        public ISprite CreateMap()
        {
            return new TextureSprite(map, 3);
        }
        public ISprite CreatePowerBracelet()
        {
            return new TextureSprite(powerBracelet, 3);
        }
        public ISprite CreateRaft()
        {
            return new TextureSprite(raft, 3);
        }
        public ISprite CreateRecorder()
        {
            return new TextureSprite(recorder, 3);
        }
        public ISprite CreateRedCandle()
        {
            return new TextureSprite(redCandle, 3);
        }
        public ISprite CreateRedRing()
        {
            return new TextureSprite(redRing, 3);
        }
        public ISprite CreateSilverArrow()
        {
            return new TextureSprite(silverArrow, 3);
        }
        public ISprite CreateStepladder()
        {
            return new TextureSprite(stepladder, 3);
        }
        public ISprite CreateSword()
        {
            return new TextureSprite(sword, 3);
        }
        public ISprite CreateWhiteSword()
        {
            return new TextureSprite(whiteSword, 3);
        }

        //animated
        public ISprite CreateFairy()
        {
            return new TextureSprite(fairy, 3, 1, 2, 5);
        }
        public ISprite CreateHeart()
        {
            return new TextureSprite(heart, 3, 1, 2, 5);
        }
        public ISprite CreateRupy()
        {
            return new TextureSprite(rupy, 3, 1, 2, 5);
        }
        public ISprite CreateTriforce()
        {
            return new TextureSprite(triforce, 3, 1, 2, 5);
        }
    }
}
