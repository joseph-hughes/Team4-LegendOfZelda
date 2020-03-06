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

        public DungeonLevel(IPlayer player)
        {
            Map = new Map();
            HUD = new DungeonHUD(this);
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
            Map.North();
        }

        public void East()
        {
            Map.East();
        }

        public void South()
        {
            Map.South();
        }

        public void West()
        {
            Map.West();
        }

        public void Other()
        {
            Map.Other();
        }

        public void Update()
        {
            Map.Update();
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
