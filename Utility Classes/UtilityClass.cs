using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Team4_LegendOfZelda.Utility_Classes
{
    class UtilityClass
    {
        // LegendOfZelda.cs

        public int WINDOW_WIDTH()
        {
            return (768);
        }
        public int ROOM_HEIGHT()
        {
            return 528;
        }
        public int HUD_HEIGHT()
        {
            return 158;
        }

        private static UtilityClass instance = new UtilityClass();

        public static UtilityClass Instance
        {
            get
            {
                return instance;
            }
        }



        public int linkInitialX = 96;
        public int linkInitialY = 260;
        //private int rectangleWidth = 7 * 3;
        //private int rectangleHeight = 3 * 3;

        public List<Rectangle> mouseActivationAreas = new List<Rectangle>
            {
                new Rectangle(40*3, 44*3, 7*3, 3*3),
                new Rectangle(32*3, 44*3, 7*3, 3*3),
                new Rectangle(48*3, 44*3, 7*3, 3*3),
                new Rectangle(40*3, 40*3, 7*3, 3*3),
                new Rectangle(32*3, 36*3, 7*3, 3*3),
                new Rectangle(40*3, 36*3, 7*3, 3*3),
                new Rectangle(48*3, 36*3,7*3, 3*3),
                new Rectangle(24*3, 32*3, 7*3, 3*3),
                new Rectangle(32*3, 32*3, 7*3, 3*3),
                new Rectangle(40*3, 32*3, 7*3, 3*3),
                new Rectangle(48*3, 32*3, 7*3, 3*3),
                new Rectangle(56*3, 32*3, 7*3, 3*3),
                new Rectangle(40*3, 28*3,7*3, 3*3),
                new Rectangle(56*3, 28*3, 7*3, 3*3),
                new Rectangle(64*3, 28*3, 7*3, 3*3),
                new Rectangle(24*3, 24*3, 7*3, 3*3),
                new Rectangle(32*3, 24*3, 7*3, 3*3),
                new Rectangle(40*3, 24*3, 7*3, 3*3),
            };

        public List<Rectangle> getMouseActivationAreas()
        {
            return this.mouseActivationAreas;
        }

        public int Aquamentus_MAX_ATTACK_COUNTER()
        {
            return 60;
        }

        public int Aquamentus_Velocity()
        {
            return 2;
        }

        public int Dodongo_Velocity()
        {
            return 0;
        }

        public int Dodongo_Walking_Velocity()
        {
            return 2;
        }

        public int Dodongo_DamageCounter()
        {
            return 120;
        }

        public int Aquamentus_WIDTH()
        {
            return 24;
        }

        public int Aquamentus_Height()
        {
            return 32;
        }

        private const int MAX_DIRECTION_COUNTS = 60, MIN_ATTACK_COUNTS = 100, MAX_ATTACK_COUNTS = 180;

        public int AquamentusController_MAX_DIRECTION_COUNTS()
        {
            return 60;
        }

        public int AquamentusController_MIN_ATTACK_COUNTS()
        {
            return 100;
        }

        public int AquamentusController_MAX_ATTACK_COUNTS()
        {
            return 180;
        }

        public float Scale()
        {
            return 3f;
        }

        public int DodongoController_MIN_DIRECTION_COUNTS()
        {
            return 30;
        }

        public int DodongoController_MAX_DIRECTION_COUNTS()
        {
            return 60;
        }

        public int BladeTrapAttack_Speed()
        {
            return 10;
        }

        public int BladeTrapRecharge_Speed()
        {
            return 4;
        }

        public int GelDarkBlue_Speed()
        {
            return 2;
        }

        public int GoriyaRed_MAX_COUNTS()
        {
            return 60;
        }

        public int GoriyaRed_HEIGHT()
        {
            return 16;
        }
        public int GoriyaRed_WIDTH2()
        {
            return 13;
        }

        public int GoriyaRed_WIDTH()
        {
            return 14;
        }

        public int GoriyaRed_SPEED()
        {
            return 1;
        }

        public int KeeseBlue_SPEED()
        {
            return 3;
        }

        public int Rope_WIDTH()
        {
            return 16;
        }
        public int Rope_HEIGHT()
        {
            return 15;
        }
        public int Rope_SPEED()
        {
            return 1;
        }

        public int Stalfos_SPEED()
        {
            return 2;
        }

        public int WallMaster_SPEED()
        {
            return 1;
        }
        public int WallMaster_WIDTH()
        {
            return 16;
        }
        public int WallMaster_HEIGHT()
        {
            return 16;
        }
        public int ZolDarkGreen_SPEED()
        {
            return 2;
        }

        public int BladeTrap_width()
        {
            return 16;
        }
        public int BladeTrap_height()
        {
            return 16;
        }

        public int BladeTrap_ACTIVATION_DISTANCE_STD()
        {
            return 300;
        }
        public int GoriyaController_MIN_DIRECTION_COUNTS()
        {
            return 30;
        }
        public int GoriyaController_MAX_DIRECTION_COUNTS()
        {
            return 120;
        }
        public int JellyController_MIN_WAIT_COUNTS()
        {
            return 5;
        }
        public int JellyController_MAX_WAIT_COUNTS()
        {
            return 20;
        }
        public int JellyController_MAX_DISPLACEMENT_STD()
        {
            return 16;
        }
        public int KeeseBlue_WIDTH()
        {
            return 16;
        }
        public int KeeseBlue_HEIGHT()
        {
            return 10;
        }
        private const int MIN_FLYING_COUNTS = 60, MAX_FLYING_COUNTS = 100, MIN_WAITING_COUNT = 20, MAX_WAITNG_COUNT = 80, MIN_DIRECTION_COUNT = 0, MAX_DIRECTION_COUNT = 15;

        public int KeeseController_MIN_FLYING_COUNTS()
        {
            return 60;
        }
        public int KeeseController_MAX_FLYING_COUNTS()
        {
            return 100;
        }
        public int KeeseController_MIN_WAITING_COUNT()
        {
            return 20;
        }
        public int KeeseController_MAX_WAITING_COUNT()
        {
            return 80;
        }
        public int KeeseController_MIN_DIRECTION_COUNT()
        {
            return 0;
        }
        public int KeeseController_MAX_DIRECTION_COUNT()
        {
            return 15;
        }
        public int RopeController_MIN_DIRECTION_COUNT()
        {
            return 10;
        }
        public int RopeController_MAX_DIRECTION_COUNT()
        {
            return 50;
        }
        public int Stalfos_WIDTH()
        {
            return 15;
        }
        public int Stalfos_HEIGHT()
        {
            return 16;
        }
        public int StalfosController_MIN_DIRECTION_COUNTS()
        {
            return 5;
        }
        public int StalfosController_MAX_DIRECTION_COUNTS()
        {
            return 30;
        }
        public int WallMaster_ACTIVATION_DISTANCE_STD()
        {
            return 40;
        }
        public int RoomChangeGameState_transitionTimer()
        {
            return 100;
        }

        public int Arrow_WIDTH()
        {
            return 5;
        }
        public int Arrow_HEIGHT()
        {
            return 16;
        }
        public int BlueCandle_WIDTH()
        {
            return 8;
        }
        public int BlueCandle_HEIGHT()
        {
            return 16;
        }
        public int BlueRing_WIDTH()
        {
            return 7;
        }
        public int BlueRing_HEIGHT()
        {
            return 9;
        }
        public int Bomb_WIDTH()
        {
            return 8;
        }
        public int Bomb_HEIGHT()
        {
            return 14;
        }
        public int BookOfMagic_WIDTH()
        {
            return 8;
        }
        public int BookOfMagic_HEIGHT()
        {
            return 16;
        }
        public int Boomerang_WIDTH()
        {
            return 5;
        } 
        public int Boomerang_HEIGHT()
        {
            return 8;
        }
        public int Bow_WIDTH()
        {
            return 8;
        }
        public int Bow_HEIGHT()
        {
            return 16;
        }
        public int Clock_WIDTH()
        {
            return 11;
        }
        public int Clock_HEIGHT()
        {
            return 16;
        }
        public int Compass_WIDTH()
        {
            return 11;
        }
        public int Compass_HEIGHT()
        {
            return 12;
        }
        public int EmptyItem_WIDTH()
        {
            return 1;
        }
        public int EmptyItem_HEIGHT()
        {
            return 1;
        }
        public int Fairy_WIDTH()
        {
            return 8;
        }
        public int Fairy_HEIGHT()
        {
            return 16;
        }
       public int FiveRupies_WIDTH()
        {
            return 8;
        }
        public int FiveRupies_HEIGHT()
        {
            return 16;
        }
        public int Food_WIDTH()
        {
            return 8;
        }
        public int Food_HEIGHT()
        {
            return 16;
        }
        public int Heart_WIDTH()
        {
            return 7;
        }
        public int Heart_HEIGHT()
        {
            return 8;
        }
        public int HeartContainer_WIDTH()
        {
            return 13;
        }
        public int HeartContainer_HEIGHT()
        {
            return 13;
        }
        public int Key_WIDTH()
        {
            return 8;
        }
        public int Key_HEIGHT()
        {
            return 16;
        }
        public int Letter_WIDTH()
        {
            return 8;
        }
        public int Letter_HEIGHT()
        {
            return 16;
        }
        public int LifePotion_WIDTH()
        {
            return 8;
        }
        public int LifePotion_HEIGHT()
        {
            return 16;
        }
        public int MagicalBoomerang_WIDTH()
        {
            return 5;
        }
        public int MagicalBoomerang_HEIGHT()
        {
            return 8;
        }
        public int MagicalKey_WIDTH()
        {
            return 8;
        }
        public int MagicalKey_HEIGHT()
        {
            return 16;
        }
        public int MagicalRod_WIDTH()
        {
            return 4;
        }
        public int MagicalRod_HEIGHT()
        {
            return 16;
        }
        public int MagicalShield_WIDTH()
        {
            return 8;
        }
        public int MagicalShield_HEIGHT()
        {
            return 12;
        }
        public int MapItem_WIDTH()
        {
            return 8;
        }
        public int MapItem_HEIGHT()
        {
            return 16;
        }
        public int PowerBracelet_WIDTH()
        {
            return 8;
        }
        public int PowerBracelet_HEIGHT()
        {
            return 14;
        }
        public int Raft_WIDTH()
        {
            return 14;
        }
        public int Raft_HEIGHT()
        {
            return 16;
        }
        public int Recorder_WIDTH()
        {
            return 3;
        }
        public int Recorder_HEIGHT()
        {
            return 16;
        }
        public int RedCandle_WIDTH()
        {
            return 8;
        }
        public int RedCandle_HEIGHT()
        {
            return 16;
        }
        public int RedRing_WIDTH()
        {
            return 7;
        }
        public int RedRing_HEIGHT()
        {
            return 9;
        }
        public int Rupy_WIDTH()
        {
            return 8;
        }
        public int Rupy_HEIGHT()
        {
            return 16;
        }
        public int SecondPotion_WIDTH()
        {
            return 8;
        }
        public int SecondPotion_HEIGHT()
        {
            return 16;
        }
        public int SilverArrow_WIDTH()
        {
            return 5;
        }
        public int SilverArrow_HEIGHT()
        {
            return 16;
        }
        public int Stepladder_WIDTH()
        {
            return 16;
        }
        public int Stepladder_HEIGHT()
        {
            return 16;
        }
        public int Sword_WIDTH()
        {
            return 7;
        }
        public int Sword_HEIGHT()
        {
            return 16;
        }
        public int Triforce_WIDTH()
        {
            return 10;
        }
        public int Triforce_HEIGHT()
        {
            return 10;
        }
        public int WhiteSword_WIDTH()
        {
            return 7;
        }
        public int WhiteSword_HEIGHT()
        {
            return 16;
        }


        public List<Keys> keyList = new List<Keys>
            {
                Keys.W,
                Keys.A,
                Keys.S,
                Keys.D,
                Keys.Up,
                Keys.Left,
                Keys.Down,
                Keys.Right,
            };

        public MouseState leftButtonPressed = new MouseState(0, 0, 0, ButtonState.Pressed, 0, 0, 0, 0);

   







    }
}
