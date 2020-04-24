using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Team4_LegendOfZelda.IBlock_Classes;

namespace Team4_LegendOfZelda.ILevel_Classes.Levels
{
    class DungeonLevel : ILevel
    {
        public IFileLoader FileLoader { get; set; }
        public IMap Map { get; set; }
        public IHUD HUD { get; set; }
        public IPlayer Player { get; set; }
        public List<IRoom> Rooms { get; set; }
        public IRoom CurrentRoom { get; set; }

        public DungeonLevel(IPlayer player, int levelNum)
        {
            FileLoader = new LevelLoader(1);
            Map = new Map(levelNum);
            HUD = new DungeonHUD(this, levelNum);
            Player = player;
            Rooms = new List<IRoom>();
            CurrentRoom = new DungeonRoom();
        }

        public void Initialize(int windowWidth, int roomHeight, int hudHeight)
        {
            Map.Initialize(0, hudHeight, windowWidth, roomHeight);
            HUD.Initialize(0, 0, windowWidth, hudHeight);
            Rooms = FileLoader.LoadRooms(Player);

            if (Rooms.Count > 0)
            {
                CurrentRoom = Rooms[0];
            }

            foreach (IRoom room in Rooms)
            {
                room.Wall = new List<IBlock>{
                new Block(false, new Microsoft.Xna.Framework.Rectangle(0, hudHeight, 93, 525), null),
                new Block(false, new Microsoft.Xna.Framework.Rectangle(0, hudHeight, 765, 93), null),
                new Block(false, new Microsoft.Xna.Framework.Rectangle(0, 432 + hudHeight, 765, 93), null),
                new Block(false, new Microsoft.Xna.Framework.Rectangle(672, hudHeight, 93, 525), null),
                };
                room.Boundary = new List<IBlock>{
                new Boundary(new Microsoft.Xna.Framework.Rectangle(-93, hudHeight, 93, 525)),
                new Boundary(new Microsoft.Xna.Framework.Rectangle(0, hudHeight-93, 765, 93)),
                new Boundary(new Microsoft.Xna.Framework.Rectangle(0, 525 + hudHeight, 765, 93)),
                new Boundary(new Microsoft.Xna.Framework.Rectangle(765, hudHeight, 93, 525))
                };
            }
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
