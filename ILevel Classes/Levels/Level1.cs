using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes.Levels
{
    class Level1 : ILevel
    {
        public ISprite Map { get; set; }
        public IHUD HUD { get; set; }
        public IPlayer Player { get; set; }
        public List<IRoom> Rooms { get; set; }
        public IRoom CurrentRoom { get; set; }

        public Level1(IPlayer player)
        {
            //Map = MapSpriteFactory.Instance.CreateLevel1MapSprite();
            HUD = new DungeonHUD();
            Player = player;
            Rooms = new List<IRoom>();
        }

        public void Initialize()
        {
            // Load file for level to create each room
        }

        public void North()
        {
            // Transition to room north of current room
        }

        public void East()
        {
            // Transition to room north of current room
        }

        public void South()
        {
            // Transition to room north of current room
        }

        public void West()
        {
            // Transition to room north of current room
        }

        public void Other()
        {
            // Transition to current room's other room, if it exists
        }

        public void Update()
        {
            HUD.Update();
            CurrentRoom.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            HUD.Draw(spriteBatch);
            CurrentRoom.Draw(spriteBatch);
        }
    }
}
