using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda
{
    public class cycleItemPrevious : ICommand
    {
        private int itemNum = 1;
        private ItemSpriteFactory spriteFactory = ItemSpriteFactory.Instance;
        public LegendOfZelda ThisGame { get; set; }
        public cycleItemPrevious(LegendOfZelda thisGame)
        {
            ThisGame = thisGame;
        }
        public void Execute()
        {
            switch (itemNum)
            {
                case 1:
                    spriteFactory.CreateArrow().Update();
                    break;
                case 2:
                    spriteFactory.CreateBlueCandle().Update();
                    break;
                case 3:
                    spriteFactory.CreateBlueRing();
                    break;
                case 4:
                    spriteFactory.CreateBomb();
                    break;
                case 5:
                    spriteFactory.CreateBookOfMagic();
                    break;
                case 6:
                    spriteFactory.CreateBoomerang();
                    break;
                case 7:
                    spriteFactory.CreateBow();
                    break;
                case 8:
                    spriteFactory.CreateClock();
                    break;
                case 9:
                    spriteFactory.CreateCompass();
                    break;
                case 10:
                    spriteFactory.CreateEmptyItem();
                    break;
                case 11:
                    spriteFactory.CreateFairy();
                    break;
                case 12:
                    spriteFactory.CreateFiveRupies();
                    break;
                case 13:
                    spriteFactory.CreateFood();
                    break;
                case 14:
                    spriteFactory.CreateHeart();
                    break;
                case 15:
                    spriteFactory.CreateHeartContainer();
                    break;
                case 16:
                    spriteFactory.CreateKey();
                    break;
                case 17:
                    spriteFactory.CreateLetter();
                    break;
                case 18:
                    spriteFactory.CreateLifePotion();
                    break;
                case 19:
                    spriteFactory.CreateMagicalBoomerang();
                    break;
                case 20:
                    spriteFactory.CreateMagicalKey();
                    break;
                case 21:
                    spriteFactory.CreateMagicalRod();
                    break;
                case 22:
                    spriteFactory.CreateMagicalShield();
                    break;
                case 23:
                    spriteFactory.CreateMap();
                    break;
                case 24:
                    spriteFactory.CreatePowerBracelet();
                    break;
                case 25:
                    spriteFactory.CreateRaft();
                    break;
                case 26:
                    spriteFactory.CreateRecorder();
                    break;
                case 27:
                    spriteFactory.CreateRedCandle();
                    break;
                case 28:
                    spriteFactory.CreateRedRing();
                    break;
                case 29:
                    spriteFactory.CreateRupy();
                    break;
                case 30:
                    spriteFactory.CreateSecondPotion();
                    break;
                case 31:
                    spriteFactory.CreateSilverArrow();
                    break;
                case 32:
                    spriteFactory.CreateStepladder();
                    break;
                case 33:
                    spriteFactory.CreateSword();
                    break;
                case 34:
                    spriteFactory.CreateTriforce();
                    break;
                case 35:
                    spriteFactory.CreateWhiteSword();
                    break;



            }

            itemNum--;
            if (itemNum < 1)
            {
                itemNum = 35;
            }

        }
    }
}