using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Team4_LegendOfZelda.Item_Classes;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies;

namespace Team4_LegendOfZelda.ILevel_Classes.Levels
{
    class Sprint2Level : ILevel
    {
        public ISprite Map { get; set; }
        public IHUD HUD { get; set; }
        public IPlayer Player { get; set; }
        public List<IRoom> Rooms { get; set; }
        public IRoom CurrentRoom { get; set; }

        public Sprint2Level(IPlayer player)
        {
            Map = MapSpriteFactory.Instance.CreateSprint2MapSprite();
            Player = player;
            Rooms = new List<IRoom>();
        }

        public void Initialize(int windowWidth, int roomHeight, int hudHeight)
        {
            CurrentRoom = new Sprint2Room();

            Vector2 itemStartLocation = new Vector2(480, 360);
            Vector2 enemyStartLocation = new Vector2(200, 360);

            List<IItem> items = new List<IItem>
            {
                new BlueCandle(itemStartLocation),
                new BlueRing(itemStartLocation),
                new Bomb(itemStartLocation),
                new BookOfMagic(itemStartLocation),
                new Bow(itemStartLocation),
                new Clock(itemStartLocation),
                new Compass(itemStartLocation),
                new EmptyItem(itemStartLocation),
                new Fairy(itemStartLocation),
                new FiveRupies(itemStartLocation),
                new Food(itemStartLocation),
                new Heart(itemStartLocation),
                new HeartContainer(itemStartLocation),
                new Key(itemStartLocation),
                new Letter(itemStartLocation),
                new LifePotion(itemStartLocation),
                new MagicalKey(itemStartLocation),
                new MagicalRod(itemStartLocation),
                new MagicalShield(itemStartLocation),
                new Map(itemStartLocation),
                new PowerBracelet(itemStartLocation),
                new Raft(itemStartLocation),
                new Recorder(itemStartLocation),
                new RedCandle(itemStartLocation),
                new RedRing(itemStartLocation),
                new Rupy(itemStartLocation),
                new SecondPotion(itemStartLocation),
                new SilverArrow(itemStartLocation),
                new Stepladder(itemStartLocation),
                new Sword(itemStartLocation),
                new Triforce(itemStartLocation),
                new WhiteSword(itemStartLocation)
            };
            
            List<IEnemy> enemies = new List<IEnemy>
            {
                new AquamentusWest(CurrentRoom, enemyStartLocation),
                new Dodongo(CurrentRoom, enemyStartLocation),
                new BladeTrap(CurrentRoom, enemyStartLocation),
                new GelDarkBlue(CurrentRoom, enemyStartLocation),
                new GoriyaRed(CurrentRoom, enemyStartLocation),
                new GoriyaBlue(CurrentRoom, enemyStartLocation),
                new KeeseBlue(CurrentRoom, enemyStartLocation),
                new KeeseRed(CurrentRoom, enemyStartLocation),
                new Rope(CurrentRoom, enemyStartLocation),
                new Stalfos(CurrentRoom, enemyStartLocation),
                new WallMaster(CurrentRoom, enemyStartLocation),
                new WallMasterUpsideDown(CurrentRoom, enemyStartLocation),
                new ZolDarkGreen(CurrentRoom, enemyStartLocation)
            };
            
            List <IBlock> blocks = new List<IBlock>{
                new Block(new Rectangle(0, 144, 93, 525)),
                new Block(new Rectangle(0, 144, 765, 93)),
                new Block(new Rectangle(0, 432+144, 765, 93)),
                new Block(new Rectangle(672, 144, 93, 525))
            };

            CurrentRoom.Initialize(Player, enemies, items, blocks);
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }

        public void Other()
        {
            // Do nothing
        }

        public void Update()
        {
            CurrentRoom.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Map.Draw(spriteBatch, new Rectangle(0, 144, 768, 528));
            CurrentRoom.Draw(spriteBatch);
        }
    }
}
