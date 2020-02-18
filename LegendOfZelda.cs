using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

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

        public ILevel Level { get; set; }
        public IPlayer Player { get; set; }

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
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

            Level.Initialize(Content);

            player = new Link(new Vector2(30, 100));

            controllerList = new List<IController>
            {
                new KeyboardController()
            };

            commandList = new List<ICommand>
            {
                new QuitCommand(this),          //0
                new resetGame(this),            //1
                new moveLinkDown(player),       //2
                new moveLinkLeft(player),       //3
                new moveLinkRight(player),      //4
                new moveLinkUp(player),         //5
                new nextItem(level),            //6
                new previousItem(level),        //7
                new nextEnemy(level),           //8
                new previousEnemy(level),       //9
                new linkAttack(player),         //10
                new linkChangeItem(player),     //11
                new takeDamage(player),         //12

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

            spriteFactories = new List<ISpriteFactory>
            {
                PlayerSpriteFactory.Instance,
                EnemySpriteFactory.Instance,
                NPCSpriteFactory.Instance,
                ItemSpriteFactory.Instance
            };

            Window.Title = "Sprint2 - Team 4";
            backgroundColor = Color.SteelBlue;
            commandList[1].Execute();
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
    }
}
