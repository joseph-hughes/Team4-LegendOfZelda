using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public interface IEnemy
    {
        ILevel Level { get; set; }
        ISprite Sprite { get; set; }
        IState State { get; set; }
        Vector2 Position { get; set; }
        void Idle();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
