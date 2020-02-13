using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.Item_Classes
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
        public static Item emptyItemObject = new ItemObjectEmpty();

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
        public Item GetEmptyItem()
        {
            return emptyItemObject;
        }
        public Item CreateSecondPotion(Vector2 location)
        {
            return new ItemObject(secondPotion, location, new SecondPotionState());
        }
        public Item CreateFiveRupies(Vector2 location)
        {
            return new ItemObject(fiveRupies, location, new FiveRupiesState());
        }
        public Item CreateArrow(Vector2 location)
        {
            return new ItemObject(arrow, location, new ArrowState());
        }
        public Item CreateBlueCandle(Vector2 location)
        {
            return new ItemObject(blueCandle, location, new BlueCandleState());
        }
        public Item CreateBlueRing(Vector2 location)
        {
            return new ItemObject(blueRing, location, new BlueRingState());
        }
        public Item CreateBomb(Vector2 location)
        {
            return new ItemObject(bomb, location, new BombState());
        }
        public Item CreateBookOfMagic(Vector2 location)
        {
            return new ItemObject(bookOfMagic, location, new BookOfMagicState());
        }
        public Item CreateBoomerang(Vector2 location)
        {
            return new ItemObject(boomerang, location, new BoomerangState());
        }
        public Item CreateBow(Vector2 location)
        {
            return new ItemObject(bow, location, new BowState());
        }
        public Item CreateClock(Vector2 location)
        {
            return new ItemObject(clock, location, new ClockState());
        }
        public Item CreateCompass(Vector2 location)
        {
            return new ItemObject(compass, location, new CompassState());
        }
        public Item CreateFood(Vector2 location)
        {
            return new ItemObject(food, location, new FoodState());
        }
        public Item CreateHeartContainer(Vector2 location)
        {
            return new ItemObject(heartContainer, location, new HeartContainerState());
        }
        public Item CreateKey(Vector2 location)
        {
            return new ItemObject(key, location, new KeyState());
        }
        public Item CreateLetter(Vector2 location)
        {
            return new ItemObject(letter, location, new LetterState());
        }
        public Item CreateLifePotion(Vector2 location)
        {
            return new ItemObject(lifePotion, location, new LifePotionState());
        }
        public Item CreateMagicalBoomerang(Vector2 location)
        {
            return new ItemObject(magicalBoomerang, location, new MagicalBoomerangState());
        }
        public Item CreateMagicalKey(Vector2 location)
        {
            return new ItemObject(magicalKey, location, new MagicalKeyState());
        }
        public Item CreateMagicalRod(Vector2 location)
        {
            return new ItemObject(magicalRod, location, new MagicalRodState());
        }
        public Item CreateMagicalShield(Vector2 location)
        {
            return new ItemObject(magicalShield, location, new MagicalShieldState());
        }
        public Item CreateMap(Vector2 location)
        {
            return new ItemObject(map, location, new MapState());
        }
        public Item CreatePowerBracelet(Vector2 location)
        {
            return new ItemObject(powerBracelet, location, new PowerBraceletState());
        }
        public Item CreateRaft(Vector2 location)
        {
            return new ItemObject(raft, location, new RaftState());
        }
        public Item CreateRecorder(Vector2 location)
        {
            return new ItemObject(recorder, location, new RecorderState());
        }
        public Item CreateRedCandle(Vector2 location)
        {
            return new ItemObject(redCandle, location, new RedCandleState());
        }
        public Item CreateRedRing(Vector2 location)
        {
            return new ItemObject(redRing, location, new RedRingState());
        }
        public Item CreateSilverArrow(Vector2 location)
        {
            return new ItemObject(silverArrow, location, new SilverArrowState());
        }
        public Item CreateStepladder(Vector2 location)
        {
            return new ItemObject(stepladder, location, new StepladderState());
        }
        public Item CreateSword(Vector2 location)
        {
            return new ItemObject(sword, location, new SwordState());
        }
        public Item CreateWhiteSword(Vector2 location)
        {
            return new ItemObject(whiteSword, location, new WhiteSwordState());
        }


        public Item CreateFairy(Vector2 location)
        {
            return new ItemObjectAnimated(fairy,1, 2, 5, location, new FairyState());
        }
        public Item CreateHeart(Vector2 location)
        {
            return new ItemObjectAnimated(heart, 1, 2, 5, location, new HeartState());
        }
        public Item CreateRupy(Vector2 location)
        {
            return new ItemObjectAnimated(rupy, 1, 2, 5, location, new RupyState());
        }
        public Item CreateTriforce(Vector2 location)
        {
            return new ItemObjectAnimated(triforce, 1, 2, 5, location, new TriforceState());
        }
    }
}
