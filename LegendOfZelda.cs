using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
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
        private List<ISpriteFactory> spriteFactories;
        private Color backgroundColor;

        public Sprint2Level Level { get; set; }
        public IPlayer Player { get; set; }

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 768;
            graphics.PreferredBackBufferHeight = 528;
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
            spriteFactories = new List<ISpriteFactory>
            {
                PlayerSpriteFactory.Instance,
                EnemySpriteFactory.Instance,
                NPCSpriteFactory.Instance,
                ItemSpriteFactory.Instance
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

            Level = new Sprint2Level();
            Level.Initialize(Content);

            Player = new Link(new Vector2(30, 100));

            controllerList = new List<IController>
            {
                new KeyboardController()
            };

            commandList = new List<ICommand>
            {
                new QuitCommand(this),                 //0
                new ResetGameCommand(this),            //1
                new MoveLinkSouthCommand(Player),       //2
                new MoveLinkWestCommand(Player),       //3
                new MoveLinkEastCommand(Player),      //4
                new MoveLinkNorthCommand(Player),         //5
                new NextItemCommand(Level),            //6
                new PreviousItemCommand(Level),        //7
                new NextEnemyCommand(Level),           //8
                new PreviousEnemyCommand(Level),       //9
                new LinkAttackCommand(Player),         //10
                new LinkBeDamagedCommand(Player)      //11
            };

            KeyboardController keyboard = (KeyboardController)controllerList[0];

            keyboard.RegisterCommand(Keys.W, commandList[5]);
            keyboard.RegisterCommand(Keys.A, commandList[3]);
            keyboard.RegisterCommand(Keys.S, commandList[2]);
            keyboard.RegisterCommand(Keys.D, commandList[1]);
            keyboard.RegisterCommand(Keys.Up, commandList[5]);
            keyboard.RegisterCommand(Keys.Left, commandList[3]);
            keyboard.RegisterCommand(Keys.Down, commandList[2]);
            keyboard.RegisterCommand(Keys.Right, commandList[1]);
            keyboard.RegisterCommand(Keys.Z, commandList[10]);
            keyboard.RegisterCommand(Keys.N, commandList[10]);
            keyboard.RegisterCommand(Keys.Q, commandList[0]);
            keyboard.RegisterCommand(Keys.R, commandList[1]);
            keyboard.RegisterCommand(Keys.U, commandList[6]);
            keyboard.RegisterCommand(Keys.I, commandList[7]);
            keyboard.RegisterCommand(Keys.O, commandList[8]);
            keyboard.RegisterCommand(Keys.P, commandList[9]);

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

            Level.Update();
            Player.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backgroundColor);

            Level.Draw(spriteBatch);
            Player.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
