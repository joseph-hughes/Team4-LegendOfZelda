using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Team4_LegendOfZelda.ICollider_Classes;
using Team4_LegendOfZelda.ICollider_Classes.Collider;
using Team4_LegendOfZelda.ILevel_Classes;
using Team4_LegendOfZelda.ILevel_Classes.Levels;

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
        private List<ICommand> commandList;
        private List<Keys> keyList;
        private List<ISpriteFactory> spriteFactories;
        private Color backgroundColor;
        private ILevel level;
        private IPlayer player;
        private IDector dector;
        private static int WINDOW_WIDTH = 768, ROOM_HEIGHT = 528, HUD_HEIGHT = 168;

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = WINDOW_WIDTH,
                PreferredBackBufferHeight = ROOM_HEIGHT + HUD_HEIGHT
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

            player = new Link(new Vector2(96, 240));

            level = new DungeonLevel(player, 1);
            level.Initialize(WINDOW_WIDTH, ROOM_HEIGHT, HUD_HEIGHT);

            dector = new BoxDector(player);
            dector.Update(level);

            controllerList = new List<IController>
            {
                new KeyboardController()
            };

            commandList = new List<ICommand>
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
                new LinkUseArrowCommand(player, level.CurrentRoom),         //9
                new LinkUseBoomerangCommand(player, level.CurrentRoom),     //10
                new LinkUseFireballCommand(player, level.CurrentRoom),      //11
                new LinkUseMagicBoomerangCommand(player, level.CurrentRoom) //12

            };

            KeyboardController keyboard = (KeyboardController)controllerList[0];
            keyList = new List<Keys>
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

            keyboard.RegisterUnpressedKeysCommand(keyList, commandList[8]);

            keyboard.RegisterCommand(Keys.W, commandList[2]);
            keyboard.RegisterCommand(Keys.D, commandList[3]);
            keyboard.RegisterCommand(Keys.S, commandList[4]);
            keyboard.RegisterCommand(Keys.A, commandList[5]);
            keyboard.RegisterCommand(Keys.Up, commandList[2]);
            keyboard.RegisterCommand(Keys.Right, commandList[3]);
            keyboard.RegisterCommand(Keys.Down, commandList[4]);
            keyboard.RegisterCommand(Keys.Left, commandList[5]);
            keyboard.RegisterCommand(Keys.Z, commandList[6]);
            keyboard.RegisterCommand(Keys.N, commandList[6]);
            keyboard.RegisterCommand(Keys.E, commandList[7]);
            keyboard.RegisterCommand(Keys.Q, commandList[0]);
            keyboard.RegisterCommand(Keys.R, commandList[1]);
            keyboard.RegisterCommand(Keys.D1, commandList[9]);
            keyboard.RegisterCommand(Keys.D2, commandList[10]);
            keyboard.RegisterCommand(Keys.D3, commandList[11]);
            keyboard.RegisterCommand(Keys.D4, commandList[12]);

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
