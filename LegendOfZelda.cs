using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Team4_LegendOfZelda.ICollider_Classes;
using Team4_LegendOfZelda.ICollider_Classes.Collider;
using Team4_LegendOfZelda.ILevel_Classes;

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
        private Sprint2Level level;
        private IPlayer player;
        private IDector dector;

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 768,
                PreferredBackBufferHeight = 528
            };
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
            spriteFactories = new List<ISpriteFactory>
            {
                PlayerSpriteFactory.Instance,
                EnemySpriteFactory.Instance,
                NPCSpriteFactory.Instance,
                ItemSpriteFactory.Instance,
                ProjectileSpriteFactory.Instance
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

            level = new Sprint2Level();
            level.Initialize(Content);

            player = new Link(new Vector2(30, 100));

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
                new NextItemCommand(level),                     //6
                new PreviousItemCommand(level),                 //7
                new NextEnemyCommand(level),                    //8
                new PreviousEnemyCommand(level),                //9
                new LinkAttackCommand(player),                  //10
                new LinkBeDamagedCommand(player),               //11
                new LinkIdleCommand(player),                    //12
                new LinkUseArrowCommand(player, level),         //13
                new LinkUseBoomerangCommand(player, level),     //14
                new LinkUseFireballCommand(player, level),      //15
                new LinkUseMagicBoomerangCommand(player, level) //16

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

            keyboard.RegisterUnpressedKeysCommand(keyList, commandList[12]);

            keyboard.RegisterCommand(Keys.W, commandList[2]);
            keyboard.RegisterCommand(Keys.D, commandList[3]);
            keyboard.RegisterCommand(Keys.S, commandList[4]);
            keyboard.RegisterCommand(Keys.A, commandList[5]);
            keyboard.RegisterCommand(Keys.Up, commandList[2]);
            keyboard.RegisterCommand(Keys.Right, commandList[3]);
            keyboard.RegisterCommand(Keys.Down, commandList[4]);
            keyboard.RegisterCommand(Keys.Left, commandList[5]);
            keyboard.RegisterCommand(Keys.Z, commandList[10]);
            keyboard.RegisterCommand(Keys.N, commandList[10]);
            keyboard.RegisterCommand(Keys.E, commandList[11]);
            keyboard.RegisterCommand(Keys.Q, commandList[0]);
            keyboard.RegisterCommand(Keys.R, commandList[1]);
            keyboard.RegisterCommand(Keys.U, commandList[6]);
            keyboard.RegisterCommand(Keys.I, commandList[7]);
            keyboard.RegisterCommand(Keys.O, commandList[8]);
            keyboard.RegisterCommand(Keys.P, commandList[9]);
            keyboard.RegisterCommand(Keys.D1, commandList[13]);
            keyboard.RegisterCommand(Keys.D2, commandList[14]);
            keyboard.RegisterCommand(Keys.D3, commandList[15]);
            keyboard.RegisterCommand(Keys.D4, commandList[16]);
            Window.Title = "Sprint2 - Team 4";
            backgroundColor = Color.SteelBlue;
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

            level.Update();
            player.Update();
            dector.Update(level);

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
