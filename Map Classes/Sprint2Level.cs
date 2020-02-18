using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies;
using Team4_LegendOfZelda.ISprite_Classes;
using Team4_LegendOfZelda.Item_Classes;

namespace Team4_LegendOfZelda.MapClasses
{
    public class Sprint2Level : ILevel
    {
        ISprite background;
        List<IItem> items;
        IItem currentItem;
        List<IEnemy> enemies;
        IEnemy currentEnemy;
        private Texture2D backgroundtexture;
        int item_index;
        int enemy_index;

        public Sprint2Level()
        {
            item_index = 0;
            enemy_index = 0;
        }


        public void Initialize(ContentManager content)
        {

            Vector2 item_test_vector = new Vector2(40, 40);
            backgroundtexture = content.Load<Texture2D>("MapSprites/emptyroom");

            items = new List<IItem>
            {
                new BlueCandle(item_test_vector),
                new BlueRing(item_test_vector),
                new Bomb(item_test_vector),
                new BookOfMagic(item_test_vector),
                new Bow(item_test_vector),
                new Clock(item_test_vector),
                new Compass(item_test_vector),
                new EmptyItem(item_test_vector),
                new Fairy(item_test_vector),
                new FiveRupies(item_test_vector),
                new Food(item_test_vector),
                new Heart(item_test_vector),
                new HeartContainer(item_test_vector),
                new Key(item_test_vector),
                new Letter(item_test_vector),
                new LifePotion(item_test_vector),
                new MagicalKey(item_test_vector),
                new MagicalRod(item_test_vector),
                new MagicalShield(item_test_vector),
                new Map(item_test_vector),
                new PowerBracelet(item_test_vector),
                new Raft(item_test_vector),
                new Recorder(item_test_vector),
                new RedCandle(item_test_vector),
                new RedRing(item_test_vector),
                new Rupy(item_test_vector),
                new SecondPotion(item_test_vector),
                new SilverArrow(item_test_vector),
                new Stepladder(item_test_vector),
                new Sword(item_test_vector),
                new Triforce(item_test_vector),
                new WhiteSword(item_test_vector)
            };
            currentItem = items[item_index];

            Vector2 enemy_test_vector = new Vector2(140, 140);
            enemies = new List<IEnemy>
            {
                new Aquamentus(enemy_test_vector),
                new Dodongo(enemy_test_vector),
                new BladeTrap(enemy_test_vector),
                new GelDarkBlue(enemy_test_vector),
                new GoriyaRed(enemy_test_vector),
                new GoriyaBlue(enemy_test_vector),
                new KeeseBlue(enemy_test_vector),
                new KeeseRed(enemy_test_vector),
                new Rope(enemy_test_vector),
                new Stalfos(enemy_test_vector),
                new WallMaster(enemy_test_vector),
                new WallMasterUpsideDown(enemy_test_vector),
                new ZolDarkGreen(enemy_test_vector)

            };
            currentEnemy = enemies[enemy_index];


            background = new TextureSprite(backgroundtexture);


        }

        public void NextItem()
        {
            item_index = (item_index + 1) % (items.Count);
            currentItem = items[item_index];
        }

        public void PreviousItem()
        {
            item_index = (item_index - 1) % (items.Count);
            currentItem = items[item_index];
        }

        public void NextEnemy()
        {
            enemy_index = (enemy_index + 1) % (enemies.Count);
            currentEnemy = enemies[enemy_index];
        }

        public void PreviousEnemy()
        {
            enemy_index = (enemy_index - 1) % (enemies.Count);
            currentEnemy = enemies[enemy_index];
        }

        public void Update()
        {
            currentEnemy.Update();
            currentItem.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 backgroundvector = new Vector2(0, 0);
            background.Draw(spriteBatch, backgroundvector);
            currentItem.Draw(spriteBatch);
            currentEnemy.Draw(spriteBatch);
        }

    }
}
