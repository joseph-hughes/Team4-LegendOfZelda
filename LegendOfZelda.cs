﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Team4_LegendOfZelda.ISprite_Classes;

namespace Team4_LegendOfZelda
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class LegendOfZelda : Game
    {
        private ISprite credits;
        private ISprite source;
        private SpriteFont font;
        private SpriteBatch spriteBatch;
        private static GraphicsDeviceManager graphics;
        private List<IController> controllerList;
        private List<ICommand> commandList;
        private List<ISpriteFactory> spriteFactories;
        private Color backgroundColor;
<<<<<<< Updated upstream:LegendOfZelda.cs
        private IState state;
=======
        private commandRegister comRegister = new commandRegister();
>>>>>>> Stashed changes:Game1.cs

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
                new KeyboardController()
            };
<<<<<<< Updated upstream:LegendOfZelda.cs
            commandList = new List<ICommand>
            {
                new QuitCommand(this)
            };
=======
            commandList = comRegister.getCommandList(this);
>>>>>>> Stashed changes:Game1.cs

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

            font = Content.Load<SpriteFont>("Font");

            string creditString = "Credits\nProgram Made By: Team 4\nSprites from:";
            credits = new TextSprite(font, creditString);
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
            state.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backgroundColor);

            credits.Draw(spriteBatch, new Vector2(20, 385));
            source.Draw(spriteBatch, new Vector2(20, 440));

            base.Draw(gameTime);
        }

        /// <summary>
        /// SetState will reassign the private state variable to some new IState object.
        /// </summary>
        /// <param name="newState">The new state object to assign to the game's state.</param>
        public void SetState(IState newState)
        {
            state = newState;
        }

        /// <summary>
        /// SetSource will reassign the private text variable to some new ISprite object.
        /// </summary>
        /// /// <param name="newSource">The new source text to assign to the game's source text sprite.</param>
        public void SetSource(string newSource)
        {
            source = new TextSprite(font, newSource);
        }
    }
}
