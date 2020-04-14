using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Team4_LegendOfZelda.ICollider_Classes;
using Team4_LegendOfZelda.ICollider_Classes.Collider;
using Team4_LegendOfZelda.IGameState_Classes;
using Team4_LegendOfZelda.ILevel_Classes.Levels;
using Team4_LegendOfZelda.Utility_Classes;

namespace Team4_LegendOfZelda
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class LegendOfZelda : Game
    {
        private SpriteBatch spriteBatch;
        private static GraphicsDeviceManager graphics;
        private List<IController> controllerList;
        private List<ISpriteFactory> spriteFactories;
        private ISFXFactory sfxfactory;
        private Color backgroundColor;
        public ILevel level;
        public IPlayer player;
        public IGameState gameState;
        private IDector dector;
        public const int WINDOW_WIDTH = 768, ROOM_HEIGHT = 528, HUD_HEIGHT = 168;
        private UtilityClass utilities = new UtilityClass();

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = utilities.WINDOW_WIDTH,
                PreferredBackBufferHeight = utilities.ROOM_HEIGHT + utilities.HUD_HEIGHT
            };
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            spriteFactories = new List<ISpriteFactory>
            {
                PlayerSpriteFactory.Instance,
                EnemySpriteFactory.Instance,
                NPCSpriteFactory.Instance,
                ItemSpriteFactory.Instance,
                ProjectileSpriteFactory.Instance,
                MapAndHUDSpriteFactory.Instance
            };
            sfxfactory = SFXFactory.Instance;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            player = new Link(new Vector2(utilities.linkInitialX, utilities.linkInitialY));

            level = new DungeonLevel(player, 1);
            level.Initialize(utilities.WINDOW_WIDTH, utilities.ROOM_HEIGHT, utilities.HUD_HEIGHT);

            dector = new BoxDector(player);
            dector.Update(level);

            gameState = new RoomGameState(this.gameState, level);

            controllerList = new List<IController>
            {
                new KeyboardController(),
                new MouseController()
            };

            List<ICommand> keyboardCommandList = new List<ICommand>
            {
                new QuitCommand(this),                          //0
                new ResetGameCommand(this),                     //1
                new MoveLinkNorthCommand(player),               //2
                new MoveLinkEastCommand(player),                //3
                new MoveLinkSouthCommand(player),               //4
                new MoveLinkWestCommand(player),                //5
                new LinkAttackCommand(player),                  //6
                new LinkBeDamagedCommand(player),               //7
                new LinkIdleCommand(player),                    //8
                new LinkUseArrowCommand(player, level),         //9
                new LinkUseBoomerangCommand(player, level),     //10
                new LinkUseFireballCommand(player, level),      //11
                new LinkUseMagicBoomerangCommand(player, level) //12
            };

            KeyboardController keyboard = (KeyboardController)controllerList[0];
            List<Keys> keyList = utilities.keyList;

            keyboard.RegisterUnpressedKeysCommand(keyList, keyboardCommandList[8]);

            keyboard.RegisterCommand(Keys.W, keyboardCommandList[2]);
            keyboard.RegisterCommand(Keys.D, keyboardCommandList[3]);
            keyboard.RegisterCommand(Keys.S, keyboardCommandList[4]);
            keyboard.RegisterCommand(Keys.A, keyboardCommandList[5]);
            keyboard.RegisterCommand(Keys.Up, keyboardCommandList[2]);
            keyboard.RegisterCommand(Keys.Right, keyboardCommandList[3]);
            keyboard.RegisterCommand(Keys.Down, keyboardCommandList[4]);
            keyboard.RegisterCommand(Keys.Left, keyboardCommandList[5]);
            keyboard.RegisterCommand(Keys.Z, keyboardCommandList[6]);
            keyboard.RegisterCommand(Keys.N, keyboardCommandList[6]);
            keyboard.RegisterCommand(Keys.E, keyboardCommandList[7]);
            keyboard.RegisterCommand(Keys.Q, keyboardCommandList[0]);
            keyboard.RegisterCommand(Keys.R, keyboardCommandList[1]);
            keyboard.RegisterCommand(Keys.D1, keyboardCommandList[9]);
            keyboard.RegisterCommand(Keys.D2, keyboardCommandList[10]);
            keyboard.RegisterCommand(Keys.D3, keyboardCommandList[11]);
            keyboard.RegisterCommand(Keys.D4, keyboardCommandList[12]);

            List<ICommand> mouseCommandList = new List<ICommand>
            {
                new GotoRoom1Command(this),     // 0
                new GotoRoom2Command(this),     // 1
                new GotoRoom3Command(this),     // 2
                new GotoRoom4Command(this),     // 3
                new GotoRoom5Command(this),     // 4
                new GotoRoom6Command(this),     // 5
                new GotoRoom7Command(this),     // 6
                new GotoRoom8Command(this),     // 7
                new GotoRoom9Command(this),     // 8
                new GotoRoom10Command(this),    // 9
                new GotoRoom11Command(this),    // 10
                new GotoRoom12Command(this),    // 11
                new GotoRoom13Command(this),    // 12
                new GotoRoom14Command(this),    // 13
                new GotoRoom15Command(this),    // 14
                new GotoRoom16Command(this),    // 15
                new GotoRoom17Command(this),    // 16
                new GotoRoom18Command(this),    // 17
            };

            
            List<Rectangle> mouseActivationAreas = utilities.mouseActivationAreas;

            MouseController mouse = (MouseController)controllerList[1];
            MouseState leftButtonPressed = utilities.leftButtonPressed;

            for (int index = 0; index < mouseCommandList.Count; index++)
            {
                mouse.RegisterCommand(leftButtonPressed, mouseActivationAreas[index], mouseCommandList[index]);
            }

            Window.Title = "Sprint 3 - Team 4";
            backgroundColor = Color.Black;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            foreach (ISpriteFactory spriteFactory in spriteFactories)
            {
                spriteFactory.LoadAllTextures(Content);
            }
            sfxfactory.LoadAllSFX(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // Not used
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }

            dector.Detact();
            dector.Update(level);

            level.Update();
            player.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backgroundColor);

            level.Draw(spriteBatch);
            player.Draw(spriteBatch);

            base.Draw(gameTime);
        }

        public void Restart()
        {
            Initialize();
        }
    }
}
