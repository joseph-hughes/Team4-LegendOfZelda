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
    public class Sprint2Room : IRoom
    {
        public IPlayer Player { get; set; }
        public List<IEnemy> Enemies { get; set; }
        public List<IItem> Items { get; set; }
        public List<IProjectile> Projectiles { get; set; }
        public IRoom North { get; set; }
        public IRoom East { get; set; }
        public IRoom South { get; set; }
        public IRoom West { get; set; }
        public IRoom Other { get; set; }

        private ISprite background;
        private IItem currentItem;
        private IEnemy currentEnemy;
        private Texture2D backgroundtexture;
        int itemIndex;
        int enemyIndex;

        public Sprint2Room(ContentManager content)
        {
            itemIndex = 0;
            enemyIndex = 0;

            Vector2 itemStartLocation = new Vector2(400, 150);
            backgroundtexture = content.Load<Texture2D>("MapSprites/emptyroom");

            Items = new List<IItem>
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
            currentItem = Items[itemIndex];

            Vector2 enemyStartLocation = new Vector2(140, 140);
            Enemies = new List<IEnemy>
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
            currentEnemy = Enemies[enemyIndex];

            Projectiles = new List<IProjectile>();

            background = new TextureSprite(backgroundtexture);
        }

        public void NextItem()
        {
            itemIndex = (itemIndex + 1) % Items.Count;
            currentItem = Items[itemIndex];
        }

        public void PreviousItem()
        {
            itemIndex = (itemIndex - 1) % Items.Count;
            if (itemIndex == -1)
            {
                itemIndex = Items.Count - 1;
            }
            currentItem = Items[itemIndex];
        }

        public void NextEnemy()
        {
            enemyIndex = (enemyIndex + 1) % Enemies.Count;
            currentEnemy = Enemies[enemyIndex];
        }

        public void PreviousEnemy()
        {
            enemyIndex = (enemyIndex - 1) % Enemies.Count;
            if (enemyIndex == -1)
            {
                enemyIndex = Enemies.Count - 1;
            }
            currentEnemy = Enemies[enemyIndex];
        }

        public void Update()
        {
            currentEnemy.Update();
            currentItem.Update();
            foreach (IProjectile projectile in Projectiles)
            {
                projectile.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch, new Rectangle(0, 0, 768, 528));
            currentEnemy.Draw(spriteBatch);
            currentItem.Draw(spriteBatch);
            foreach (IProjectile projectile in Projectiles)
            {
                projectile.Draw(spriteBatch);
            }
        }
    }
}
