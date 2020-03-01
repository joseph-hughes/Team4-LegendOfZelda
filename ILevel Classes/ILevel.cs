using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Team4_LegendOfZelda.ILevel_Classes;

namespace Team4_LegendOfZelda
{
    public interface ILevel
    {
        IRoom CurrentRoom { get; set; }
        void Initialize(ContentManager content, IPlayer player);
        void North();
        void East();
        void South();
        void West();
        void Other();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
