using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ItemObject
{
    class ItemFactory
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

        private static ItemFactory instance = new ItemFactory();

        public static ItemFactory Instance
        {
            get
            {
                return instance;
            }

        }
        private ItemFactory()
        {
        }
        public void LoadAllTextues(ContentManager content)
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
        }
        public ISprite CreateSecondPotionSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(secondPotion, location);
        }
        public ISprite CreateFiveRupiesSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(fiveRupies, location);
        }
        public ISprite CreateArrowSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(arrow, location);
        }
        public ISprite CreateBlueCandleSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(blueCandle, location);
        }
        public ISprite CreateBlueRingSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(blueRing, location);
        }
        public ISprite CreateBombSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(bomb, location);
        }
        public ISprite CreateBookOfMagicSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(bookOfMagic, location);
        }
        public ISprite CreateBoomerangSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(boomerang, location);
        }
        public ISprite CreateBowSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(bow, location);
        }
        public ISprite CreateClockSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(clock, location);
        }
        public ISprite CreateCompassSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(compass, location);
        }
        public ISprite CreateFoodSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(food, location);
        }
        public ISprite CreateHeartContainerSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(heartContainer, location);
        }
        public ISprite CreateKeySprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(key, location);
        }
        public ISprite CreateLetterSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(letter, location);
        }
        public ISprite CreateLifePotionSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(lifePotion, location);
        }
        public ISprite CreateMagicalBoomerangSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(magicalBoomerang, location);
        }
        public ISprite CreateMagicalKeySprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(magicalKey, location);
        }
        public ISprite CreateMagicalRodSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(magicalRod, location);
        }
        public ISprite CreateMagicalShieldSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(magicalShield, location);
        }
        public ISprite CreateMapSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(map, location);
        }
        public ISprite CreatePowerBraceletSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(powerBracelet, location);
        }
        public ISprite CreateRaftSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(raft, location);
        }
        public ISprite CreateRecorderSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(recorder, location);
        }
        public ISprite CreateRedCandleSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(redCandle, location);
        }
        public ISprite CreateRedRingSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(redRing, location);
        }
        public ISprite CreateSilverArrowSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(silverArrow, location);
        }
        public ISprite CreateStepladderSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(stepladder, location);
        }
        public ISprite CreateSwordSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(sword, location);
        }
        public ISprite CreateWhiteSwordSprite(Vector2 location)
        {
            return new CreateNonanimatedItemSprite(whiteSword, location);
        }


        public ISprite CreateFairySprite(Vector2 location)
        {
            return new CreateAnimatedItemSprite(fairy, location, 2, 8, 16);
        }
        public ISprite CreateHeartSprite(Vector2 location)
        {
            return new CreateAnimatedItemSprite(heart, location, 2, 7, 8);
        }
        public ISprite CreateRupySprite(Vector2 location)
        {
            return new CreateAnimatedItemSprite(rupy, location, 2, 8, 16);
        }
        public ISprite CreateTriforceSprite(Vector2 location)
        {
            return new CreateAnimatedItemSprite(triforce, location, 2, 10, 10);
        }
    }
}
