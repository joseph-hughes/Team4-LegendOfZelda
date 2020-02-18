using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Item_Classes;
using Team4_LegendOfZelda.ISprite_Classes;
using Microsoft.Xna.Framework.Content;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    public class Sprint2Level:ILevel
    {
        public List<IEnemy> EnemyList { get; set; }
        public List<Iitem> ItemList { get; set; }
        public List<IProjectile> ProjectileList { get; set; }
        private ISprite background;
        private Iitem currentItem;
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
            
            Vector2 itemStartLocation = new Vector2(40, 40);
            backgroundtexture = content.Load<Texture2D>("MapSprites/emptyroom");

            ItemList = new List<Iitem>
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
            currentItem = ItemList[itemIndex];

            Vector2 enemyStartLocation = new Vector2(140, 140);
            EnemyList = new List<IEnemy>
            {
                new AquamentusWest(this, enemyStartLocation),
                new Dodongo(this, enemyStartLocation),
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
            currentEnemy = EnemyList[enemyIndex];

            background = new TextureSprite(backgroundtexture);
        }

        public void NextItem()
        {
            itemIndex = (itemIndex+1) % ItemList.Count;
            currentItem = ItemList[itemIndex];
        }

        public void PreviousItem()
        {
            itemIndex = (itemIndex - 1) % ItemList.Count;
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
            currentEnemy = EnemyList[enemyIndex];
        }

        public void Update()
        {
            currentEnemy.Update();
            currentItem.Update();
            foreach (IProjectile projectile in ProjectileList)
            {
                projectile.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch, new Vector2(0, 0));
            currentEnemy.Draw(spriteBatch);
            currentItem.Draw(spriteBatch);
            foreach (IProjectile projectile in ProjectileList)
            {
                projectile.Update();
            }
        }

    }
}
