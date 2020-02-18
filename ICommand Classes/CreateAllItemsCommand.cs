using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team4_LegendOfZelda.Item_Classes;

namespace Team4_LegendOfZelda.ICommand_Classes
{
    class CreateAllItemsCommand
    {
        public CreateAllItemsCommand(Vector2 location)
        {
            Iitem Arrow = new Arrow(location);
            Iitem Boomerang = new Boomerang(location);
            Iitem MagicalBoomerang = new MagicalBoomerang(location);
            Iitem BlueCandle = new BlueCandle(location);
            Iitem BlueRing = new BlueRing(location);
            Iitem Bomb = new Bomb(location);
            Iitem BookOfMagic = new BookOfMagic(location);
            Iitem Bow = new Bow(location);
            Iitem Clock = new Clock(location);
            Iitem Compass = new Compass(location);
            Iitem EmptyItem = new EmptyItem(location);
            Iitem Fairy = new Fairy(location);
            Iitem FiveRupies = new FiveRupies(location);
            Iitem Food = new Food(location);
            Iitem Heart = new Heart(location);
            Iitem HeartContainer = new HeartContainer(location);
            Iitem Key = new Key(location);
            Iitem Letter = new Letter(location);
            Iitem LifePotion = new LifePotion(location);
            Iitem MagicalKey = new MagicalKey(location);
            Iitem MagicalRod = new MagicalRod(location);
            Iitem MagicalShield = new MagicalShield(location);
            Iitem Map = new Map(location);
            Iitem PowerBracelet = new PowerBracelet(location);
            Iitem Raft = new Raft(location);
            Iitem Recorder = new Recorder(location);
            Iitem RedCandle = new RedCandle(location);
            Iitem RedRing = new RedRing(location);
            Iitem Rupy = new Rupy(location);
            Iitem SecondPotion = new SecondPotion(location);
            Iitem SilverArrow = new SilverArrow(location);
            Iitem Stepladder = new Stepladder(location);
            Iitem Sword = new Sword(location);
            Iitem Triforce = new Triforce(location);
            Iitem WhiteSword = new WhiteSword(location);




        }
    }
}
