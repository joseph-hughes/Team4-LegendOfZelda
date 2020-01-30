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
        private ISprite sprite;
        private ISprite credits;
        private ISprite source;
        private SpriteFont font;
        private SpriteBatch spriteBatch;
        private static GraphicsDeviceManager graphics;
        private List<IController> controllerList;
        private List<ICommand> commandList;
        private Color backgroundColor;

        public LegendOfZelda()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
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

            controllerList = new List<IController>
            {
                new KeyboardController(),
                new MouseController()
            };
            commandList = new List<ICommand>
            {
                new QuitCommand(this),
                new SetNonMovingNonAnimatedSpriteCommand(this),
                new SetNonMovingAnimatedSpriteCommand(this),
                new SetMovingNonAnimatedSpriteCommand(this),
                new SetMovingAnimatedSpriteCommand(this),
            };

            KeyboardController keyboard = (KeyboardController)controllerList[0];

            keyboard.RegisterCommand(Keys.D0, commandList[0]);
            keyboard.RegisterCommand(Keys.NumPad0, commandList[0]);
            keyboard.RegisterCommand(Keys.D1, commandList[1]);
            keyboard.RegisterCommand(Keys.NumPad1, commandList[1]);
            keyboard.RegisterCommand(Keys.D2, commandList[2]);
            keyboard.RegisterCommand(Keys.NumPad2, commandList[2]);
            keyboard.RegisterCommand(Keys.D3, commandList[3]);
            keyboard.RegisterCommand(Keys.NumPad3, commandList[3]);
            keyboard.RegisterCommand(Keys.D4, commandList[4]);
            keyboard.RegisterCommand(Keys.NumPad4, commandList[4]);

            MouseController mouse = (MouseController)controllerList[1];
            MouseState rightButtonPressed = new MouseState(0, 0, 0, 0, 0, ButtonState.Pressed, 0, 0);
            MouseState leftButtonPressed = new MouseState(0, 0, 0, ButtonState.Pressed, 0, 0, 0, 0);

            int width = GraphicsDevice.Viewport.Width / 2;
            int height = GraphicsDevice.Viewport.Height / 2;

            Rectangle quadrant1 = new Rectangle(0, 0, width, height);
            Rectangle quadrant2 = new Rectangle(width, 0, width, height);
            Rectangle quadrant3 = new Rectangle(0, height, width, height);
            Rectangle quadrant4 = new Rectangle(width, height, width, height);

            mouse.RegisterCommand(rightButtonPressed, GraphicsDevice.Viewport.Bounds, commandList[0]);
            mouse.RegisterCommand(leftButtonPressed, quadrant1, commandList[1]);
            mouse.RegisterCommand(leftButtonPressed, quadrant2, commandList[2]);
            mouse.RegisterCommand(leftButtonPressed, quadrant3, commandList[3]);
            mouse.RegisterCommand(leftButtonPressed, quadrant4, commandList[4]);

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
            font = Content.Load<SpriteFont>("Font");

            string creditString = "Credits\nProgram Made By: Joseph Hughes.1792\nSprite from:";
            credits = new TextSprite(font, creditString, new Vector2(20, 385));
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
            sprite.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backgroundColor);

            sprite.Draw(spriteBatch);
            credits.Draw(spriteBatch);
            source.Draw(spriteBatch);

            base.Draw(gameTime);
        }

        /// <summary>
        /// SetSprite will reassign the private sprite variable to some new ISprite object.
        /// </summary>
        /// <param name="newSprite">The new sprite object to assign to the game's sprite.</param>
        public void SetSprite(ISprite newSprite)
        {
            sprite = newSprite;
        }

        /// <summary>
        /// SetSource will reassign the private text variable to some new ISprite object.
        /// </summary>
        /// /// <param name="newSource">The new source text to assign to the game's source text sprite.</param>
        public void SetSource(string newSource)
        {
            source = new TextSprite(font, newSource, new Vector2(20, 440));
        }
    }
}
