using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes.Levels
{
    class DungeonLevel : ILevel
    {
        public IMap Map { get; set; }
        public IHUD HUD { get; set; }
        public IPlayer Player { get; set; }
        public List<IRoom> Rooms { get; set; }
        public IRoom CurrentRoom { get; set; }

        public DungeonLevel(IPlayer player, int levelNum)
        {
            Map = new Map(levelNum);
            HUD = new DungeonHUD(this, levelNum);
            Player = player;
            Rooms = new List<IRoom>();
        }

        public void Initialize(int windowWidth, int roomHeight, int hudHeight)
        {
            Map.Initialize(0, hudHeight, windowWidth, roomHeight);
            HUD.Initialize(0, 0, windowWidth, hudHeight);
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
            Map.Draw(spriteBatch);
            HUD.Draw(spriteBatch);
            CurrentRoom.Draw(spriteBatch);
        }
    }
}
