using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies;
using Team4_LegendOfZelda.ISprite_Classes;
using Team4_LegendOfZelda.Item_Classes;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    public class Sprint2Level : ILevel
    {
        public List<IBlock> BlockList { get; set; }
        public List<IEnemy> EnemyList { get; set; }
        public List<IItem> ItemList { get; set; }
        public List<IProjectile> PlayerProjectileList { get; set; }
        public List<IProjectile> EnemyProjectileList { get; set; }

        private ISprite background;
        private IItem currentItem;
        private IEnemy currentEnemy;
        private Texture2D backgroundtexture;
        int itemIndex;
        int enemyIndex;

        public Sprint2Level()
        {
            itemIndex = 0;
            enemyIndex = 0;
        }

        public void Initialize(ContentManager content)
        {
            backgroundtexture = content.Load<Texture2D>("MapSprites/emptyroom");
            background = new TextureSprite(backgroundtexture);

            Vector2 itemStartLocation = new Vector2(400, 150);
            Vector2 enemyStartLocation = new Vector2(140, 140);

            ItemList = new List<IItem>
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

            EnemyList = new List<IEnemy>
            {
                new Dodongo(this, enemyStartLocation),
                new AquamentusWest(this, enemyStartLocation),
                new BladeTrap(this, enemyStartLocation),
                new GelDarkBlue(this, enemyStartLocation),
                new GoriyaRed(this, enemyStartLocation),
                new GoriyaBlue(this, enemyStartLocation),
                new KeeseBlue(this, enemyStartLocation),
                new KeeseRed(this, enemyStartLocation),
                new Rope(this, enemyStartLocation),
                new Stalfos(this, enemyStartLocation),
                new WallMaster(this, enemyStartLocation),
                new WallMasterUpsideDown(this, enemyStartLocation),
                new ZolDarkGreen(this, enemyStartLocation)

            };
            BlockList = new List<IBlock>{
                new Block(new Rectangle(600, 0, 100, 500))
            };

            currentItem = ItemList[itemIndex];
            currentEnemy = EnemyList[enemyIndex];

            PlayerProjectileList = new List<IProjectile>();
            EnemyProjectileList = new List<IProjectile>();


        }

        public void NextItem()
        {
            itemIndex = (itemIndex + 1) % ItemList.Count;
            currentItem = ItemList[itemIndex];
        }

        public void PreviousItem()
        {
            itemIndex = (itemIndex - 1) % ItemList.Count;
            if (itemIndex == -1)
            {
                itemIndex = ItemList.Count - 1;
            }
            currentItem = ItemList[itemIndex];
        }

        public void NextEnemy()
        {
            enemyIndex = (enemyIndex + 1) % EnemyList.Count;
            currentEnemy = EnemyList[enemyIndex];
        }

        public void PreviousEnemy()
        {
            enemyIndex = (enemyIndex - 1) % EnemyList.Count;
            if (enemyIndex == -1)
            {
                enemyIndex = EnemyList.Count - 1;
            }
            currentEnemy = EnemyList[enemyIndex];
        }

        public void Update()
        {
            currentEnemy.Update();
            currentItem.Update();
            foreach (IProjectile projectile in PlayerProjectileList)
            {
                projectile.Update();
            }
            foreach (IProjectile projectile in EnemyProjectileList)
            {
                projectile.Update();
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch, new Rectangle(0, 0, 768, 528));
            currentEnemy.Draw(spriteBatch);
            currentItem.Draw(spriteBatch);
            foreach (IProjectile projectile in PlayerProjectileList)
            {
                projectile.Draw(spriteBatch);
            }
            foreach (IProjectile projectile in EnemyProjectileList)
            {
                projectile.Draw(spriteBatch);
            }
        }

    }
}
