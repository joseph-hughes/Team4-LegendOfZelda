using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda.ILevel_Classes.Levels
{
    class Level1 : ILevel
    {
        //public MapSprite Map { get; set; }
        public IRoom CurrentRoom { get; set; }

        public void Initialize(ContentManager content, IPlayer player)
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
            CurrentRoom.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            CurrentRoom.Draw();
        }
    }
}
