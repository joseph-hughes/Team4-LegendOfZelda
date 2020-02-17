using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.Item_Classes;
using Team4_LegendOfZelda.ISprite_Classes;
using Microsoft.Xna.Framework.Content;
using Team4_LegendOfZelda.IEnemy_Classses.Bosses;
using Team4_LegendOfZelda.IEnemy_Classses.Dungeon_Enemies;

namespace Team4_LegendOfZelda.MapClasses
{
    public class Sprint2Level:ILevel
    {
        ISprite background;
        List<Iitem> items;
        Iitem currentItem;
        List<IEnemy> enemies;
        IEnemy currentEnemy;
        private Texture2D backgroundtexture;
        ContentManager content;
        int item_index;
        int enemy_index;

        public Sprint2Level()
        {
            item_index = 0;
            enemy_index = 0;
        }

        
        public void Initialize()
        {
            
            Vector2 bcv = new Vector2(40, 40);
            backgroundtexture = content.Load<Texture2D>("MapSprites/emptyroom");

            items = new List<Iitem>
            {
                new BlueCandle(bcv),
                new BlueRing(bcv),
                new Bomb(bcv),
                new BookOfMagic(bcv),
                new Bow(bcv),
                new Clock(bcv),
                new Compass(bcv),
                new EmptyItem(bcv),
                new Fairy(bcv),
                new FiveRupies(bcv),
                new Food(bcv),
                new Heart(bcv),
                new HeartContainer(bcv),
                new Key(bcv),
                new Letter(bcv),
                new LifePotion(bcv),
                new MagicalKey(bcv),
                new MagicalRod(bcv),
                new MagicalShield(bcv),
                new Map(bcv),
                new PowerBracelet(bcv),
                new Raft(bcv),
                new Recorder(bcv),
                new RedCandle(bcv),
                new RedRing(bcv),
                new Rupy(bcv),
                new SecondPotion(bcv),
                new SilverArrow(bcv),
                new Stepladder(bcv),
                new Sword(bcv),
                new Triforce(bcv),
                new WhiteSword(bcv)



            };
            currentItem = items[item_index];

            enemies = new List<IEnemy>
            {
                new Aquamentus(bcv),
                new Dodongo(bcv),
                new BladeTrap(bcv),
                new GelDarkBlue(bcv),
                new GoriyaRed(bcv),
                new GoriyaBlue(bcv),
                new KeeseBlue(bcv),
                new KeeseRed(bcv),
                new Rope(bcv),
                new Stalfos(bcv),
                new WallMaster(bcv),
                new WallMasterUpsideDown(bcv),
                new ZolDarkGreen(bcv)

            };
            currentEnemy = enemies[enemy_index];


            background = new TextureSprite(backgroundtexture);


        }

        public void NextItem()
        {
            item_index = (item_index+1)%(items.Count);
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
