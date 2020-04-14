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

        //DungeonHUD.cs

        public int STD_HUD_X = 0, STD_HUD_Y = 0, STD_HUD_WIDTH = 256, STD_HUD_HEIGHT = 56;
        public int STD_MINIMAP_X = 16, STD_MINIMAP_Y = 16, STD_MINIMAP_WIDTH = 64, STD_MINIMAP_HEIGHT = 32;
        public int STD_LEVEL_NUM_X = 64, STD_LEVEL_NUM_Y = 8, STD_LEVEL_NUM_WIDTH = 8, STD_LEVEL_NUM_HEIGHT = 8;
        public int STD_HEART_1_X = 176, STD_HEART_1_Y = 40, STD_HEART_WIDTH = 8, STD_HEART_HEIGHT = 8;
        public int STD_HEART_COLUMNS = 8, STD_HEART_ROWS = 2;

        //LevelLoader.cs

        public int RowColumnMultiplier = 48;
        public int ColumnAddVal = 33;
        public int RowAddVal = 168;

        //AquamentusEastAttackState

        public int count = 0;
        public int maxcount = 60;

        //DodongoEastDamagedState.. plus other dodongo states

        //public int maxcount2;

        // Aquamentus.cs

        public float Scale = 3f;

        // AquamentusController

        public int MAX_DIRECTION_COUNTS = 40, MIN_ATTACK_COUNTS = 100, MAX_ATTACK_COUNTS = 180;

        // DodongoController

        public int MIN_DIRECTION_COUNTS = 100, MAX_DIRECTION_COUNTS2 = 300;

        // BladeTrapEastState.cs

        public int MAX_DISPLACEMENT = 240, DELTA_DISPLACEMENT = 16;

        // Boomerang.cs

        public int MAX_DISPLACEMENT2 = 48, DELTA_DISPLACEMENT2 = 2;

        // GoriyaBlueEastAttackState.cs

        public int width = 14, height = 16;

        // GoriyaBlueNorthAttackState
        public int width2 = 13;

        //ropeeaststate.cs

        public int height2 = 15;
        public int width3 = 16;

        // StalfosEastState.cs

        public int speed = 2;

        // ZolDarkGreenState.cs

        public int DELTA_DISPLACEMENT3 = 10;

        // BladeTrapController

        public int MIN_DIRECTION_COUNTS2 = 60;
        public int MAX_DIRECTION_COUNTS3 = 180;

        // GelDarkBlueController.cs

        public int MAX_DIRECTION_COUNTS4 = 60;

        // GoriyaController.cs

        public int MAX_DIRECTION_COUNTS5 = 240;

        // KeeseBlue.cs

        public int height3 = 10;

        //KeeseController

        public int MAX_DIRECTION_COUNTS6 = 30;

        // Stalfos.cs

        public int width4 = 15;

        // wallmastercontroller.cs

        public int MAX_DIRECTION_COUNTS7 = 240;




    }
}
