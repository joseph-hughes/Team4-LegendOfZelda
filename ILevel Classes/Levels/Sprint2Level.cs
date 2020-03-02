using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4_LegendOfZelda.ILevel_Classes.Levels
{
    class Sprint2Level : ILevel
    {
        public IRoom CurrentRoom { get; set; }

        public void Initialize(ContentManager content, IPlayer player)
        {
            CurrentRoom = new Sprint2Room(content);
        }

        public void North()
        {
            // Do nothing
        }

        public void East()
        {
            // Do nothing
        }

        public void South()
        {
            // Do nothing
        }

        public void West()
        {
            // Do nothing
        }

        public void Other()
        {
            // Do nothing
        }

        public void Update()
        {
            CurrentRoom.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            CurrentRoom.Draw(spriteBatch);
        }
    }
}
