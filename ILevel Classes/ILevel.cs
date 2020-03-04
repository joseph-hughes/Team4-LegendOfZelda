using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public interface ILevel
    {
        ISprite Map { get; set; }
        IHUD HUD { get; set; }
        IPlayer Player { get; set; }
        System.Collections.Generic.List<IRoom> Rooms { get; set; }
        IRoom CurrentRoom { get; set; }

        void Initialize();
        void North();
        void East();
        void South();
        void West();
        void Other();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
